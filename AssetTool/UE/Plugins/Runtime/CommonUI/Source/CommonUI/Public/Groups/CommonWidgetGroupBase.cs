namespace AssetTool
{
    [JsonAsset("CommonWidgetGroupBase")]
    public class UCommonWidgetGroupBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}