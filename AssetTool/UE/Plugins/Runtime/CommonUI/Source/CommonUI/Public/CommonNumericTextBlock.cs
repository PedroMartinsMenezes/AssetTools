namespace AssetTool
{
    [JsonAsset("CommonNumericTextBlock")]
    public class UCommonNumericTextBlock : UCommonTextBlock
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}