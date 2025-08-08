namespace AssetTool
{
    [JsonAsset("ChaosVDConstraintDataComponent")]
    public class UChaosVDConstraintDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}