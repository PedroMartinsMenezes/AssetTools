namespace AssetTool
{
    [JsonAsset("SmartObjectContainerRenderingComponent")]
    public class USmartObjectContainerRenderingComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}