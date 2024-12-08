namespace AssetTool
{
    [JsonAsset("PhysicsVolume")]
    public class APhysicsVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}