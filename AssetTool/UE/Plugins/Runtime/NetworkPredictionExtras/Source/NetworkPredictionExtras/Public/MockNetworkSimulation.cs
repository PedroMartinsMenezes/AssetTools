namespace AssetTool
{
    [JsonAsset("MockNetworkSimulationComponent")]
    public class UMockNetworkSimulationComponent : UNetworkPredictionComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}