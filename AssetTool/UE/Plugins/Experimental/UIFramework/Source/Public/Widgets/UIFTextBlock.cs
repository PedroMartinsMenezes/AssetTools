namespace AssetTool
{
    [JsonAsset("UIFrameworkTextBase")]
    public class UUIFrameworkTextBase : UUIFrameworkWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIFrameworkTextBlock")]
    public class UUIFrameworkTextBlock : UUIFrameworkTextBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}