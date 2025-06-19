namespace AssetTool
{
    [JsonAsset("UserWidgetExtension")]
    public class UUserWidgetExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}