namespace AssetTool
{
    [JsonAsset("LyraWidgetFactory")]
    public class ULyraWidgetFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}