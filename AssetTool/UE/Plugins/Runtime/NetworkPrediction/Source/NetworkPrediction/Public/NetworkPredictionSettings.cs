namespace AssetTool
{
    [JsonAsset("NetworkPredictionSettingsObject")]
    public class UNetworkPredictionSettingsObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}