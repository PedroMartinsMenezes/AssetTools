namespace AssetTool
{
    [JsonAsset("CommonNumericTextBlock")]
    public class UCommonNumericTextBlock : UCommonTextBlock
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}