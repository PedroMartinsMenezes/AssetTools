namespace AssetTool
{
    [JsonAsset("LyraHealthSet")]
    public class ULyraHealthSet : ULyraAttributeSet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}