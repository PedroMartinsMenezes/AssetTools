namespace AssetTool
{
    [JsonAsset("NavLinkDefinition")]
    public class UNavLinkDefinition : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}