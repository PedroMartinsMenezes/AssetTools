namespace AssetTool
{
    [JsonAsset("LyraInputConfig")]
    public class ULyraInputConfig : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}