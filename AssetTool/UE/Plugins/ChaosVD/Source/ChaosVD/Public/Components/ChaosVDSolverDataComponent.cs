namespace AssetTool
{
    [JsonAsset("ChaosVDSolverDataComponent")]
    public class UChaosVDSolverDataComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}