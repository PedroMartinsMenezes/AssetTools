namespace AssetTool
{
    [JsonAsset("FloatingPropertiesSettings")]
    public class UFloatingPropertiesSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}