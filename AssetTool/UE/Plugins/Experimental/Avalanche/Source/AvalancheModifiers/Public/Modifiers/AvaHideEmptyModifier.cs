namespace AssetTool
{
    [JsonAsset("AvaHideEmptyModifier")]
    public class UAvaHideEmptyModifier : UAvaArrangeBaseModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}