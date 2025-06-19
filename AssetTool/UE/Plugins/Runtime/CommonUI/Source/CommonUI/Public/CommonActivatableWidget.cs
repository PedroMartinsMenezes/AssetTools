namespace AssetTool
{
    [JsonAsset("CommonActivatableWidget")]
    public class UCommonActivatableWidget : UCommonUserWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}