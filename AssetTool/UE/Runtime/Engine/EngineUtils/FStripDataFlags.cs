namespace AssetTool
{
    public class FStripDataFlags
    {
        public byte GlobalStripFlags;
        public byte ClassStripFlags;

        public FStripDataFlags Read(BinaryReader reader)
        {
            reader.Read(ref GlobalStripFlags);
            reader.Read(ref ClassStripFlags);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(GlobalStripFlags);
            writer.Write(ClassStripFlags);
        }
    }
}
