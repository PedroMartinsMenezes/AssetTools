namespace AssetTool
{
    [JsonAsset("CommonActivatableWidget")]
    public class UCommonActivatableWidget : UCommonUserWidget
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}