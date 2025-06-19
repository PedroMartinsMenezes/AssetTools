namespace AssetTool
{
    [JsonAsset("CommonWidgetGroupBase")]
    public class UCommonWidgetGroupBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}