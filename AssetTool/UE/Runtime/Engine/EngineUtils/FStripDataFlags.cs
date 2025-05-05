namespace AssetTool
{
    public class FStripDataFlags : ITransferible
    {
        public byte GlobalStripFlags;
        public byte ClassStripFlags;

        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.IsCompatible())
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

        public bool IsAudioVisualDataStripped() => (GlobalStripFlags & (byte)EStrippedData.AudioVisual) != 0;

        public enum EStrippedData : byte
        {
            None = 0,
            EditorOnly = 1,
            Editor = EditorOnly,
            AudioVisual = 2,
            Server = AudioVisual,
            NeededForCooking = 4,
            All = 0xff
        };
    }
}
