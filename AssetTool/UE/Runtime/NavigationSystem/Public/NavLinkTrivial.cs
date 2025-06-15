namespace AssetTool
{
    [JsonAsset("NavLinkTrivial")]
    public class UNavLinkTrivial : UNavLinkDefinition
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}