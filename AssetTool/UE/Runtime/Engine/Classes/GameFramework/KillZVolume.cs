namespace AssetTool
{
    [JsonAsset("KillZVolume")]
    public class AKillZVolume : APhysicsVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}