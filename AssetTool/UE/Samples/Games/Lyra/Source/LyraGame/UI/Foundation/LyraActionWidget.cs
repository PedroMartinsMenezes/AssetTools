namespace AssetTool
{
    [JsonAsset("LyraActionWidget")]
    public class ULyraActionWidget : UCommonActionWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}