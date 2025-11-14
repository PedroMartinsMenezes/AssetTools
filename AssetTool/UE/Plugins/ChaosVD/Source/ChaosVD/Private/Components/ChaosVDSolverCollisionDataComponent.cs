namespace AssetTool
{
    [JsonAsset("ChaosVDSolverCollisionDataComponent")]
    public class UChaosVDSolverCollisionDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}