namespace AssetTool
{
    [JsonAsset("NavLinkDefinition")]
    public class UNavLinkDefinition : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}