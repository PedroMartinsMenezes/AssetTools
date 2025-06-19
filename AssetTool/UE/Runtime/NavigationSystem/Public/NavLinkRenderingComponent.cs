namespace AssetTool
{
    [JsonAsset("NavLinkRenderingComponent")]
    public class UNavLinkRenderingComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}