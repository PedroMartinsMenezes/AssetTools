namespace AssetTool
{
    [JsonAsset("ChaosVDSolverTrackSettings")]
    public class UChaosVDSolverTrackSettings : UChaosVDSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}