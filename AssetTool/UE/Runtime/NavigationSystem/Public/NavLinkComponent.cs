namespace AssetTool
{
    [JsonAsset("NavLinkComponent")]
    public class UNavLinkComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}