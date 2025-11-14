namespace AssetTool
{
    [JsonAsset("CommonActivatableWidget")]
    public class UCommonActivatableWidget : UCommonUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}