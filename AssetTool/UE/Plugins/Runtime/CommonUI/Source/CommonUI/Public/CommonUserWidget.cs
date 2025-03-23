namespace AssetTool
{
    [JsonAsset("CommonUserWidget")]
    public class UCommonUserWidget : UUserWidget
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}