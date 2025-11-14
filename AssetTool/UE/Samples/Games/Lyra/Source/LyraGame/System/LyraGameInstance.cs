namespace AssetTool
{
    [JsonAsset("LyraGameInstance")]
    public class ULyraGameInstance : UCommonGameInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}