namespace AssetTool
{
    [JsonAsset("SmartObjectDebugRenderingComponent")]
    public class USmartObjectDebugRenderingComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}