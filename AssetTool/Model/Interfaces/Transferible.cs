using System.Text;

namespace AssetTool
{
    public interface ITransferible
    {
        ITransferible Move(Transfer transfer);
    }

    public interface ITransferibleStruct
    {
        ITransferible Move(Transfer transfer, int num, object value);
    }

    public abstract class Transferible<T> : ITransferible
    {
        public abstract ITransferible Move(Transfer transfer);

        public T ToJsonThenToObject()
        {
            return this.ToJson().ToObject<T>();
        }

        public bool SelfCheck(string name, Transfer transfer, long[] offsets)
        {
            if (!AppConfig.AutoCheck || (offsets[1] - offsets[0]) == 0) return true;
            bool logEnabled = Log.Enabled;
            Log.Enabled = false;
            Transfer currentTransfer = transfer;
            try
            {
                long currentPosition = transfer.Position;
                byte[] sourceBytes = new byte[offsets[1] - offsets[0]];
                using BinaryReader reader = new BinaryReader(transfer.Stream, Encoding.Default, true);
                reader.BaseStream.Position = offsets[0];
                reader.Read(sourceBytes);

                using MemoryStream dest = new();
                using BinaryWriter writer = new BinaryWriter(dest);

                Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 1;
                GlobalObjects.Transfer = new TransferWriter(writer);
                Move(GlobalObjects.Transfer);

                byte[] destBytes = new byte[offsets[1] - offsets[0]];
                dest.Position = 0;
                _ = dest.Read(destBytes);

                var self2 = ToJsonThenToObject() as Transferible<T>;
                using MemoryStream dest2 = new();
                using BinaryWriter writer2 = new BinaryWriter(dest2);

                Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 2;
                GlobalObjects.Transfer = new TransferWriter(writer2);
                self2.Move(GlobalObjects.Transfer);

                byte[] destBytes2 = new byte[offsets[1] - offsets[0]];
                dest2.Position = 0;
                _ = dest2.Read(destBytes2);

                string msg = string.Empty;
                if (!DataComparer.CompareBytes(sourceBytes, destBytes, offsets[0]))
                    msg = $"    Binary Difference Found for {name}";

                if (msg.Length == 0 && !DataComparer.CompareBytes(destBytes, destBytes2, offsets[0]))
                    msg = $"    Json Difference Found for {name}";

                if (msg.Length > 0)
                {
                    Log.Error(msg);
                    this.SaveToJson($"C:/Temp/{name}-Source.json");
                    self2.SaveToJson($"C:/Temp/{name}-Dest.json");
                    File.WriteAllBytes($"C:/Temp/{name}-Source.dat", sourceBytes);
                    File.WriteAllBytes($"C:/Temp/{name}-Dest.dat", destBytes);

                    Log.Error($"    Counter: {currentTransfer.Counter}");
                    throw new InvalidOperationException(msg);
                }

                GlobalObjects.Transfer = currentTransfer;
                transfer.Position = currentPosition;
                Log.Enabled = logEnabled;
                return msg.Length == 0;
            }
            catch
            {
                Log.Enabled = logEnabled;
                GlobalObjects.Transfer = currentTransfer;
                throw;
            }
        }
    }
}
