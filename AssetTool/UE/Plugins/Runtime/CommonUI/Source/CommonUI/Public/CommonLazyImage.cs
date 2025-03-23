namespace AssetTool
{
    [JsonAsset("CommonLazyImage")]
    public class UCommonLazyImage : UImage
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}