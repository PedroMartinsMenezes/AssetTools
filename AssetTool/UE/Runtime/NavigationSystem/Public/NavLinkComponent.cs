namespace AssetTool
{
    [JsonAsset("NavLinkComponent")]
    public class UNavLinkComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}