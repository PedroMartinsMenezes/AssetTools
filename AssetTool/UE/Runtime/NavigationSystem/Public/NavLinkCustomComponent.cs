namespace AssetTool
{
    [JsonAsset("NavLinkCustomComponent")]
    public class UNavLinkCustomComponent : UNavRelevantComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}