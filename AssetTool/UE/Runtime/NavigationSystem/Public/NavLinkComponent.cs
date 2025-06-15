namespace AssetTool
{
    [JsonAsset("NavLinkComponent")]
    public class UNavLinkComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}