namespace AssetTool
{
    [JsonAsset("SimulationAsset")]
    public class USimulationAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}