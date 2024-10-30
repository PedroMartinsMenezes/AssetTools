namespace AssetTool
{
    [JsonAsset("WidgetDesignerSettings")]
    public class UWidgetDesignerSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}