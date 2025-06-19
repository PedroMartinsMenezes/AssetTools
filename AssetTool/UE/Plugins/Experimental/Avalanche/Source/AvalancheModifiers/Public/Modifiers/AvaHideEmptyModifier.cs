namespace AssetTool
{
    [JsonAsset("AvaHideEmptyModifier")]
    public class UAvaHideEmptyModifier : UAvaArrangeBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}