namespace AssetTool
{
    [JsonAsset("SmartObjectDebugRenderingComponent")]
    public class USmartObjectDebugRenderingComponent : UDebugDrawComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}