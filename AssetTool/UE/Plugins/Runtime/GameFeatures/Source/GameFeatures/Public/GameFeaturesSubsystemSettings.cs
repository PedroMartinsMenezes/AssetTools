namespace AssetTool
{
    [JsonAsset("GameFeaturesSubsystemSettings")]
    public class UGameFeaturesSubsystemSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}