namespace AssetTool
{
    [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    public class USceneThumbnailInfoWithPrimitive : UObject
    {
        public const string TypeName = "SceneThumbnailInfoWithPrimitive";

        public USceneThumbnailInfoWithPrimitive Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
        }
    }
}
