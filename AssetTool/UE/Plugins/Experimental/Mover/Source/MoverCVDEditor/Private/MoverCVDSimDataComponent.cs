namespace AssetTool
{
    [JsonAsset("MoverCVDSimDataComponent")]
    public class UMoverCVDSimDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}