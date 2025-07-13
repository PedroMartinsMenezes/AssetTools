namespace AssetTool
{
    [JsonAsset("SmartObjectContainerRenderingComponent")]
    public class USmartObjectContainerRenderingComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}