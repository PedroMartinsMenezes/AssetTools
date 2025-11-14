namespace AssetTool
{
    [JsonAsset("RadialForceActor")]
    public class ARadialForceActor : ARigidBodyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}