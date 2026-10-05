using System.Diagnostics;

namespace AssetTool
{
    [Obsolete("Never use this class")]
    [DebuggerDisplay("{Data.Length}")]
    public class WorkaroundPad : ITransferable
    {
        private static readonly object _lock = new();
        public byte[] Data;

        public WorkaroundPad() { }

        public WorkaroundPad(long size)
        {
            Data = new byte[size];
        }

        public ITransferable Move(Transfer transfer)
        {
            if (transfer.AppConfig.LogWorkaroundPad)
            {
                lock (_lock)
                {
                    if (transfer.IsReading)
                    {
                        var obj = transfer.GlobalObjects.CurrentObject;
                        obj = obj ?? new AssetObject { Index = -1, ClassName = "Header" };
                        string line = $"{transfer.GlobalObjects.FileName} ExportIndex[{obj.Index}] Size({Data.Length}) {obj.ClassName}";
                        File.AppendAllText("C:/Temp/WorkaroundPad.txt", $"{line}\n");
                    }
                }
            }
            transfer.Move(ref Data, Data.Length);
            return this;
        }

        public static WorkaroundPad CreateOrDefault(Transfer transfer, WorkaroundPad defaultValue, long expectedPosition)
        {
            if (defaultValue is { })
            {
                return defaultValue;
            }
            long size = expectedPosition - transfer.Position;
            return size > 0 ? new WorkaroundPad(size) : null;
        }
    }
}
