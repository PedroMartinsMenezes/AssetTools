namespace AssetTool
{
    [JsonAsset("NavLinkTrivial")]
    public class UNavLinkTrivial : UNavLinkDefinition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}