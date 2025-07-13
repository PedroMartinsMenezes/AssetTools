namespace AssetTool
{
    [JsonAsset("MockNetworkSimulationComponent")]
    public class UMockNetworkSimulationComponent : UNetworkPredictionComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}