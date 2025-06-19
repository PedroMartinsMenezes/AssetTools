namespace AssetTool
{
    [JsonAsset("NetworkPredictionSettingsObject")]
    public class UNetworkPredictionSettingsObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}