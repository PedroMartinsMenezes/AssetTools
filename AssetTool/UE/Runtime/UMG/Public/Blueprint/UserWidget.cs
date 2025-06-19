namespace AssetTool
{
    [JsonAsset("UserWidget")]
    public class UUserWidget : UWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}