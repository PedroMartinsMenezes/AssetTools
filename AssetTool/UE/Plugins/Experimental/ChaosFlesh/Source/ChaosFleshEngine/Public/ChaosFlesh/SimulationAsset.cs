namespace AssetTool
{
    [JsonAsset("SimulationAsset")]
    public class USimulationAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}