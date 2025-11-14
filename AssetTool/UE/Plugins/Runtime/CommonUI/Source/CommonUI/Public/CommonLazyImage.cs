namespace AssetTool
{
    [JsonAsset("CommonLazyImage")]
    public class UCommonLazyImage : UImage
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}