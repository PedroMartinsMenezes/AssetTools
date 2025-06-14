namespace AssetTool
{
    [JsonAsset("NetworkPredictionSettingsObject")]
    public class UNetworkPredictionSettingsObject : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}