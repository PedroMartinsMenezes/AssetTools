namespace AssetTool
{
    [JsonAsset("PathedPhysicsDebugDrawComponent")]
    public class UPathedPhysicsDebugDrawComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}