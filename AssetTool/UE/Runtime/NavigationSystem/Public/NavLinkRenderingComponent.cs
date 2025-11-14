namespace AssetTool
{
    [JsonAsset("NavLinkRenderingComponent")]
    public class UNavLinkRenderingComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}