namespace AssetTool
{
    [JsonAsset("ChaosVDSolverTrackSettings")]
    public class UChaosVDSolverTrackSettings : UChaosVDSettingsObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}