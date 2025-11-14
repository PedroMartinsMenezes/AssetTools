namespace AssetTool
{
    [JsonAsset("PathedPhysicsDebugDrawComponent")]
    public class UPathedPhysicsDebugDrawComponent : UDebugDrawComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}