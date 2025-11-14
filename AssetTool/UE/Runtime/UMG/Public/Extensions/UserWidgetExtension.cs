namespace AssetTool
{
    [JsonAsset("UserWidgetExtension")]
    public class UUserWidgetExtension : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}