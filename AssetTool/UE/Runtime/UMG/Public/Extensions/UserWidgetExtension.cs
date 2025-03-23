namespace AssetTool
{
    [JsonAsset("UserWidgetExtension")]
    public class UUserWidgetExtension : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}