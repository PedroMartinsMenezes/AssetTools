namespace AssetTool
{
    [JsonAsset("UIFrameworkPresenter")]
    public class UUIFrameworkPresenter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIFrameworkGameViewportPresenter")]
    public class UUIFrameworkGameViewportPresenter : UUIFrameworkPresenter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}