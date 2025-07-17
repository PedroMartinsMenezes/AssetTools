namespace AssetTool
{
    [JsonAsset("LyraHealthSet")]
    public class ULyraHealthSet : ULyraAttributeSet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}