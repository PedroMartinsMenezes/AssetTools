namespace AssetTool
{
    [JsonAsset("PhysicsVolume")]
    public class APhysicsVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}