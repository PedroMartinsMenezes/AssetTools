namespace AssetTool
{
    [JsonAsset("ChaosMoverSimulation")]
    public class UChaosMoverSimulation : UMoverSimulation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}