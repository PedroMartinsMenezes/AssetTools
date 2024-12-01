namespace AssetTool
{
    [JsonAsset("PhysicsThruster")]
    public class APhysicsThruster : ARigidBodyBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}