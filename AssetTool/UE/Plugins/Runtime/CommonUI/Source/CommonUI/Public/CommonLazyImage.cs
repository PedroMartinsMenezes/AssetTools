namespace AssetTool
{
    [JsonAsset("CommonLazyImage")]
    public class UCommonLazyImage : UImage
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}