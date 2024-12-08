namespace AssetTool
{
    [JsonAsset("DefaultPhysicsVolume")]
    public class ADefaultPhysicsVolume : APhysicsVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}