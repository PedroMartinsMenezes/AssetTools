namespace AssetTool
{
    [JsonAsset("ChaosMoverSimulation")]
    public class UChaosMoverSimulation : UMoverSimulation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}