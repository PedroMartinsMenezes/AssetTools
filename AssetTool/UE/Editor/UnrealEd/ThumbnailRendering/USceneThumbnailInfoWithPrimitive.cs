namespace AssetTool
{
    [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    [JsonAsset]
    public class USceneThumbnailInfoWithPrimitive : UObject
    {
        public const string TypeName = "SceneThumbnailInfoWithPrimitive";
    }
}
