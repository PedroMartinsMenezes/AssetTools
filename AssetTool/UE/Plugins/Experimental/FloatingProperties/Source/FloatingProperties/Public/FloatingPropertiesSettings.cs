namespace AssetTool
{
    [JsonAsset("FloatingPropertiesSettings")]
    public class UFloatingPropertiesSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}