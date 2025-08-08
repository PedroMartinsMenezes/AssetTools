namespace AssetTool
{
    [JsonAsset("ChaosVDSolverDataComponent")]
    public class UChaosVDSolverDataComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}