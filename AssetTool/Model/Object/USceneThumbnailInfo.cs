namespace AssetTool
{
    public class USceneThumbnailInfo : UThumbnailInfo
    {
        public const string TypeName = "SceneThumbnailInfo";

        public new USceneThumbnailInfo Move(Transfer transfer) => (USceneThumbnailInfo)base.Move(transfer);
    }
}
