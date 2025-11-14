namespace AssetTool
{
    [JsonAsset("UserWidget")]
    public class UUserWidget : UWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}