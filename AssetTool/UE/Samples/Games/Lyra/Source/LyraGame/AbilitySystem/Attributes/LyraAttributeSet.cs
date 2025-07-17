namespace AssetTool
{
    [JsonAsset("LyraAttributeSet")]
    public class ULyraAttributeSet : UAttributeSet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}