namespace AssetTool
{
    [JsonAsset("UIFrameworkButton")]
    public class UUIFrameworkButton : UUIFrameworkWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIFrameworkButtonWidget")]
    public class UUIFrameworkButtonWidget : UButton
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}