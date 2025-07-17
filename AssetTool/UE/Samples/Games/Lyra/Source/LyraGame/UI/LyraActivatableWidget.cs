namespace AssetTool
{
    [JsonAsset("LyraActivatableWidget")]
    public class ULyraActivatableWidget : UCommonActivatableWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}