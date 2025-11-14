namespace AssetTool
{
    [JsonAsset("LyraActivatableWidget")]
    public class ULyraActivatableWidget : UCommonActivatableWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}