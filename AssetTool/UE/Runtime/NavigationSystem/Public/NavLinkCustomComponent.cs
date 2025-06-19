namespace AssetTool
{
    [JsonAsset("NavLinkCustomComponent")]
    public class UNavLinkCustomComponent : UNavRelevantComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}