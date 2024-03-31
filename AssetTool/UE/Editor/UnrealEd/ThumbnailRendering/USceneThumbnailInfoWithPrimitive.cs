namespace AssetTool
{
    [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    public class USceneThumbnailInfoWithPrimitive : UObject
    {
        public const string TypeName = "SceneThumbnailInfoWithPrimitive";

        public USceneThumbnailInfoWithPrimitive Read(BinaryReader reader)
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
