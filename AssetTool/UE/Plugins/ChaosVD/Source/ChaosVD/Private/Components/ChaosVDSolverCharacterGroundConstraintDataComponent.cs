namespace AssetTool
{
    [JsonAsset("ChaosVDSolverCharacterGroundConstraintDataComponent")]
    public class UChaosVDSolverCharacterGroundConstraintDataComponent : UChaosVDConstraintDataComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}