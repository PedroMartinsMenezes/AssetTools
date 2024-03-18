namespace AssetTool
{
    public class UThumbnailInfo : UObject
    {
        public new UThumbnailInfo Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
