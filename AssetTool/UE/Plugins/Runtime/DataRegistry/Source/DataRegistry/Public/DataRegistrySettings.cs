namespace AssetTool
{
    [JsonAsset("DataRegistrySettings")]
    public class UDataRegistrySettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}