namespace AssetTool
{
    [JsonAsset("NavLinkDefinition")]
    public class UNavLinkDefinition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}