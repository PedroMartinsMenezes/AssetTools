namespace AssetTool
{
    [JsonAsset("MoverCVDSimDataComponent")]
    public class UMoverCVDSimDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}