namespace AssetTool
{
    [JsonAsset("ChaosVDSolverCollisionDataComponent")]
    public class UChaosVDSolverCollisionDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}