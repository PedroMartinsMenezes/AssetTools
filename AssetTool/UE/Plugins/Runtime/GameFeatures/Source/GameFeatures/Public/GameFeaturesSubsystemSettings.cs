namespace AssetTool
{
    [JsonAsset("GameFeaturesSubsystemSettings")]
    public class UGameFeaturesSubsystemSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}