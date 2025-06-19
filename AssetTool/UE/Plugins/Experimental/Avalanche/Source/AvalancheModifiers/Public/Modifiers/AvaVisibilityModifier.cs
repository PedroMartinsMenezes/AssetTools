namespace AssetTool
{
    [JsonAsset("AvaVisibilityModifier")]
    public class UAvaVisibilityModifier : UAvaArrangeBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}