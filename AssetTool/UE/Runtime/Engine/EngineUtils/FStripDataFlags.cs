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

        public bool IsEditorDataStripped() => GlobalStripFlags > 0 && GlobalStripFlags == (byte)EStrippedData.Editor;

        public bool IsDataStrippedForServer() => GlobalStripFlags > 0 && GlobalStripFlags == (byte)EStrippedData.Server;

        public enum EStrippedData
        {
            None = 0,
            Editor = 1,
            Server = 2,
            All = 0xff
        };
    }
}
