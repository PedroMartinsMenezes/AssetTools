using System.Diagnostics;

namespace AssetTool
{
    [Obsolete("Never use this class")]
    [DebuggerDisplay("{Data.Length}")]
    public class WorkaroundPad
    {
        public byte[] Data;

        public WorkaroundPad() { }

        public WorkaroundPad(long size)
        {
            Data = new byte[size];
        }

        public void Move(Transfer transfer)
        {
            transfer.Move(ref Data, Data.Length);
        }

        public void Move(Transfer transfer, long size)
        {
            transfer.Move(ref Data, (int)size);
        }

        public static WorkaroundPad CreateOrDefault(Transfer transfer, WorkaroundPad defaultValue)
        {
            if (defaultValue is { })
            {
                return defaultValue;
            }
            long size = transfer.GlobalObjects.CurrentObject.NextOffset - transfer.Position;
            if (size > 0)
            {
                return new WorkaroundPad(size);
            }
            else
            {
                return null;
            }
        }
    }
}
