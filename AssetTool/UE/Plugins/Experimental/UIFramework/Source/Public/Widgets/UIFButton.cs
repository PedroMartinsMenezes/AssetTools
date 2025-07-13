namespace AssetTool
{
    [JsonAsset("UIFrameworkButton")]
    public class UUIFrameworkButton : UUIFrameworkWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIFrameworkButtonWidget")]
    public class UUIFrameworkButtonWidget : UButton
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}