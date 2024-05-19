namespace AssetTool
{
    public class FStripDataFlags
    {
        public byte GlobalStripFlags;
        public byte ClassStripFlags;

        public FStripDataFlags Move(Transfer transfer)
        {
            transfer.Move(ref GlobalStripFlags);
            transfer.Move(ref ClassStripFlags);
            return this;
        }
    }
}
