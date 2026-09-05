using System.Text;

namespace AssetTool
{
    public interface ITransferable
    {
        ITransferable Move(Transfer transfer);
    }

    public interface ITransferableRaw
    {
        ITransferable MoveRaw(Transfer transfer);
    }

    public interface ITransferable<in T1> : ITransferable
    {
        ITransferable Move(Transfer transfer, T1 arg1);
    }

    public interface ITransferable<in T1, in T2> : ITransferable
    {
        ITransferable Move(Transfer transfer, T1 arg1, T2 arg2);
    }

    public interface ITransferable<in T1, in T2, in T3> : ITransferable
    {
        ITransferable Move(Transfer transfer, T1 arg1, T2 arg2, T3 arg3);
    }

    public interface ITransferableSelector : ITransferable
    {
        object Move(Transfer transfer, int num, object value);
    }

    public interface ITransferablePropertyTag : ITransferable
    {
        bool IsPropertyTag(Transfer transfer);
    }

    public interface ITransferableAutoCheck
    {
        ITransferable MoveAutoCheck(Transfer transfer);
    }

    public class TransferableAutoCheck : ITransferableAutoCheck, ITransferable
    {
        public virtual ITransferable MoveAutoCheck(Transfer transfer)
        {
            throw new System.NotImplementedException();
        }

        public ITransferable Move(Transfer transfer)
        {
            long[] offsets = [transfer.Position, 0];
            if (transfer.IsReading)
            {
                MoveAutoCheck(transfer);
                offsets[1] = transfer.Position;
                transfer.AppConfig.DebugCheckMember = true;
                AutoCheck(transfer, GetType().ToString(), transfer.Stream, offsets);
                transfer.AppConfig.DebugCheckMember = false;
            }
            else
            {
                MoveAutoCheck(transfer);
            }
            return this;
        }

        public bool AutoCheck(Transfer transfer, string name, Stream source, long[] offsets)
        {
            if (transfer.IsWriting || !transfer.AppConfig.DebugCheckMember || (offsets[1] - offsets[0]) == 0) return true;

            string msg = string.Empty;
            long currentPosition = source.Position;
            byte[] sourceBytes = new byte[offsets[1] - offsets[0]];
            using BinaryReader reader = new BinaryReader(source, Encoding.Default, true);
            reader.BaseStream.Position = offsets[0];
            reader.Read(sourceBytes);

            if (transfer.AppConfig.AutoCheckBinaryWriter)
            {
                Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 1;
                using MemoryStream dest = new();
                using BinaryWriter writer = new BinaryWriter(dest);
                using TransferWriter transferWriter = new TransferWriter(writer, transfer);

                MoveAutoCheck(transferWriter);

                byte[] destBytes = new byte[offsets[1] - offsets[0]];
                dest.Position = 0;
                _ = dest.Read(destBytes);

                if (msg.Length == 0 && DataComparer.CompareBytes(sourceBytes, destBytes, offsets[0], sourceBytes.Length) is string msg1 && msg1.Length > 0)
                    msg = $"    Binary Difference Found for {name}\n{msg1}";
            }

            string json = this.ToJson();
            Type type = GetType();
            var copy = json.ToObject(type, transfer) as ITransferableAutoCheck;

            Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 2;
            using MemoryStream dest2 = new();
            using BinaryWriter writer2 = new BinaryWriter(dest2);
            using TransferWriter transferWriter2 = new TransferWriter(writer2, transfer, true, true);

            copy.MoveAutoCheck(transferWriter2);

            byte[] destBytes2 = new byte[offsets[1] - offsets[0]];
            dest2.Position = 0;
            _ = dest2.Read(destBytes2);

            if (msg.Length == 0 && DataComparer.CompareBytes(sourceBytes, destBytes2, offsets[0], sourceBytes.Length) is string msg2 && msg2.Length > 0)
                msg = $"    Json Difference Found for {name}\n{msg2}";

            if (currentPosition != offsets[1])
                msg = $"    Wrong read size. Expected: {offsets[1]}. Actual: {currentPosition}";

            if (msg.Length > 0)
            {
                File.WriteAllText("C:/Temp/Before.json", this.ToJson());
                File.WriteAllText("C:/Temp/After.json", copy.ToJson());
                File.WriteAllText("C:/Temp/Before.raw.json", this.ToRawJson());
                File.WriteAllText("C:/Temp/After.raw.json", copy.ToRawJson());
                Log.Error(msg);
                Log.Error($"    Counter: {transfer.Counter}");
                throw new InvalidOperationException(msg);
            }

            source.Position = currentPosition;
            return msg.Length == 0;
        }
    }
}
