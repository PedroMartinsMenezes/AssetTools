using System.Text;

namespace AssetTool
{
    public interface ITransferible
    {
        ITransferible Move(Transfer transfer);
    }

    public interface ITransferibleRaw
    {
        ITransferible MoveRaw(Transfer transfer);
    }

    public interface ITransferible<in T1> : ITransferible
    {
        ITransferible Move(Transfer transfer, T1 arg1);
    }

    public interface ITransferible<in T1, in T2> : ITransferible
    {
        ITransferible Move(Transfer transfer, T1 arg1, T2 arg2);
    }

    public interface ITransferible<in T1, in T2, in T3> : ITransferible
    {
        ITransferible Move(Transfer transfer, T1 arg1, T2 arg2, T3 arg3);
    }

    public interface ITransferibleSelector : ITransferible
    {
        object Move(Transfer transfer, int num, object value);
    }

    public abstract class Transferible<T> : ITransferible
    {
        public abstract ITransferible Move(Transfer transfer);

        public T ToJsonThenToObject(Transfer transfer)
        {
            return this.ToJson(transfer).ToObject<T>(transfer);
        }

        public bool SelfCheck(string name, Transfer transfer, long[] offsets)
        {
            if (!AppConfig.DebugCheckMember || (offsets[1] - offsets[0]) == 0) return true;
            bool logEnabled = Log.Enabled;
            Log.Enabled = false;
            string msg = string.Empty;
            try
            {
                long currentPosition = transfer.Position;
                byte[] sourceBytes = new byte[offsets[1] - offsets[0]];
                using BinaryReader reader = new BinaryReader(transfer.Stream, Encoding.Default, true);
                reader.BaseStream.Position = offsets[0];
                reader.Read(sourceBytes);

                if (AppConfig.AutoCheckWriter1)
                {
                    Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 1;
                    using MemoryStream dest = new();
                    using BinaryWriter writer = new BinaryWriter(dest);
                    using TransferWriter transferWriter = new TransferWriter(writer, transfer);
                    Move(transferWriter);

                    byte[] destBytes = new byte[offsets[1] - offsets[0]];
                    dest.Position = 0;
                    _ = dest.Read(destBytes);

                    if (DataComparer.CompareBytes2(sourceBytes, destBytes, offsets[0]) is string msg1 && msg1.Length > 0)
                    {
                        msg = $"    Binary Difference Found for {name}\n{msg1}";
                        File.WriteAllBytes($"C:/Temp/{name}-Source.dat", sourceBytes);
                        File.WriteAllBytes($"C:/Temp/{name}-Dest.dat", destBytes);
                    }
                }

                var copy = ToJsonThenToObject(transfer) as Transferible<T>;
                Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 2;
                using MemoryStream dest2 = new();
                using BinaryWriter writer2 = new BinaryWriter(dest2);
                using TransferWriter transferWriter2 = new TransferWriter(writer2, transfer, true);
                copy.Move(transferWriter2);

                byte[] destBytes2 = new byte[offsets[1] - offsets[0]];
                dest2.Position = 0;
                _ = dest2.Read(destBytes2);

                if (msg.Length == 0 && DataComparer.CompareBytes2(sourceBytes, destBytes2, offsets[0]) is string msg2 && msg2.Length > 0)
                    msg = $"    Json Difference Found for {name}\n{msg2}";

                if (msg.Length > 0)
                {
                    Log.Error(msg);
                    File.WriteAllBytes($"C:/Temp/{name}-Source.dat", sourceBytes);
                    File.WriteAllBytes($"C:/Temp/{name}-Dest2.dat", destBytes2);
                    this.SaveToJson($"C:/Temp/{name}-Source.json", transfer);
                    copy.SaveToJson($"C:/Temp/{name}-Dest.json", transfer);
                    Log.Error($"    Counter: {transfer.Counter}");
                    throw new InvalidOperationException(msg);
                }

                transfer.Position = currentPosition;
                Log.Enabled = logEnabled;
                return msg.Length == 0;
            }
            catch
            {
                Log.Enabled = logEnabled;
                throw;
            }
        }
    }
}
