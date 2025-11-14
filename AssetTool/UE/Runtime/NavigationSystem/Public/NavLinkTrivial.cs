namespace AssetTool
{
    [JsonAsset("NavLinkTrivial")]
    public class UNavLinkTrivial : UNavLinkDefinition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}