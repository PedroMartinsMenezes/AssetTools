namespace AssetTool
{
    [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    public class USceneThumbnailInfoWithPrimitive : UObject
    {
        public const string TypeName = "SceneThumbnailInfoWithPrimitive";

        public new USceneThumbnailInfoWithPrimitive Move(Transfer transfer) => (USceneThumbnailInfoWithPrimitive)base.Move(transfer);
    }
}
