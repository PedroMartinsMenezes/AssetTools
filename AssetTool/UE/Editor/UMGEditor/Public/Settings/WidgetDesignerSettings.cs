namespace AssetTool
{
    [JsonAsset("WidgetDesignerSettings")]
    public class UWidgetDesignerSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}