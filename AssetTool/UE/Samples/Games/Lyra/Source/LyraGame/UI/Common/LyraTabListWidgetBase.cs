namespace AssetTool
{
    [JsonAsset("LyraTabListWidgetBase")]
    public class ULyraTabListWidgetBase : UCommonTabListWidgetBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}