namespace AssetTool
{
    [JsonAsset("RadialForceActor")]
    public class ARadialForceActor : ARigidBodyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}