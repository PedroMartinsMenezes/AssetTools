namespace AssetTool
{
    [JsonAsset("LyraInputConfig")]
    public class ULyraInputConfig : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}