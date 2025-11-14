namespace AssetTool
{
    [JsonAsset("NavLinkCustomComponent")]
    public class UNavLinkCustomComponent : UNavRelevantComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}