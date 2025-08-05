namespace AssetTool
{
    public class FStripDataFlags : ITransferible
    {
        public EStrippedData GlobalStripFlags;
        public byte ClassStripFlags;

        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.IsCompatible())
            {
                transfer.MoveEnum(ref GlobalStripFlags);
                transfer.Move(ref ClassStripFlags);
            }
            return this;
        }

        public bool IsClassDataStripped(byte InFlags)
        {
            return (ClassStripFlags & InFlags) != 0;
        }

        public bool IsEditorDataStripped() => GlobalStripFlags.HasFlag(EStrippedData.Editor);

        public bool IsDataStrippedForServer() => GlobalStripFlags.HasFlag(EStrippedData.Server);

        public bool IsAudioVisualDataStripped() => GlobalStripFlags.HasFlag(EStrippedData.AudioVisual);

        [Flags]
        public enum EStrippedData : byte
        {
            None = 0,
            EditorOnly = 1,
            Editor = EditorOnly,
            AudioVisual = 2,
            Server = AudioVisual,
            NeededForCooking = 4
        };
    }
}
