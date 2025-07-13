namespace AssetTool
{
    [JsonAsset("SmartObjectRenderingComponent")]
    public class USmartObjectRenderingComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}