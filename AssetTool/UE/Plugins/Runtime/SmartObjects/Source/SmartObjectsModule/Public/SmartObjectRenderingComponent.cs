namespace AssetTool
{
    [JsonAsset("SmartObjectRenderingComponent")]
    public class USmartObjectRenderingComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}