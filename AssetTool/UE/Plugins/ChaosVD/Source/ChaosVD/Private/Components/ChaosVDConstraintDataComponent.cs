namespace AssetTool
{
    [JsonAsset("ChaosVDConstraintDataComponent")]
    public class UChaosVDConstraintDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}