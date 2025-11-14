namespace AssetTool
{
    [JsonAsset("UIFrameworkTextBase")]
    public class UUIFrameworkTextBase : UUIFrameworkWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIFrameworkTextBlock")]
    public class UUIFrameworkTextBlock : UUIFrameworkTextBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}