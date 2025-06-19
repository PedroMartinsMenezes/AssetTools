namespace AssetTool
{
    [JsonAsset("PhysicsThruster")]
    public class APhysicsThruster : ARigidBodyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}