namespace AssetTool
{
    public class USceneThumbnailInfo : UThumbnailInfo
    {
        public const string TypeName = "SceneThumbnailInfo";

        public new USceneThumbnailInfo Read(BinaryReader reader)
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
