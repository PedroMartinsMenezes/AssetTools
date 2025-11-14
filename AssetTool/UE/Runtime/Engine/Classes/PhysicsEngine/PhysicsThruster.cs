namespace AssetTool
{
    [JsonAsset("PhysicsThruster")]
    public class APhysicsThruster : ARigidBodyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}