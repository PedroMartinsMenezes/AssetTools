namespace AssetTool
{
    [JsonAsset("LyraPerfStatWidgetBase")]
    public class ULyraPerfStatWidgetBase : UCommonUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraPerfStatGraph")]
    public class ULyraPerfStatGraph : UUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}