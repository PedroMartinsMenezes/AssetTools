namespace AssetTool
{
    public class FStripDataFlags : ITransferible
    {
        public byte GlobalStripFlags;
        public byte ClassStripFlags;

        public ITransferible Move(Transfer transfer)
        {
            if (Supports.IsCompatible())
            {
                transfer.Move(ref GlobalStripFlags);
                transfer.Move(ref ClassStripFlags);
            }
            return this;
        }

        public bool IsClassDataStripped(byte InFlags)
        {
            return (ClassStripFlags & InFlags) != 0;
        }

        public bool IsEditorDataStripped() => (GlobalStripFlags & (byte)EStrippedData.Editor) != 0;

        public bool IsDataStrippedForServer() => (GlobalStripFlags & (byte)EStrippedData.Server) != 0;

        public enum EStrippedData
        {
            None = 0,
            Editor = 1,
            Server = 2,
            All = 0xff
        };
    }
}
