namespace AssetTool
{
    [JsonAsset("KillZVolume")]
    public class AKillZVolume : APhysicsVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}