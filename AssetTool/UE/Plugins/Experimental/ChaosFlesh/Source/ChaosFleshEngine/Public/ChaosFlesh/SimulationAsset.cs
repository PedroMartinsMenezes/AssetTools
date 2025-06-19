namespace AssetTool
{
    [JsonAsset("SimulationAsset")]
    public class USimulationAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}