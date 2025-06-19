namespace AssetTool
{
    [JsonAsset("AvaTranslucentPriorityModifier")]
    public class UAvaTranslucentPriorityModifier : UAvaArrangeBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}