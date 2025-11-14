namespace AssetTool
{
    [JsonAsset("UIFrameworkPresenter")]
    public class UUIFrameworkPresenter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIFrameworkGameViewportPresenter")]
    public class UUIFrameworkGameViewportPresenter : UUIFrameworkPresenter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}