namespace AssetTool
{
    [JsonAsset("UserWidget")]
    public class UUserWidget : UWidget
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}