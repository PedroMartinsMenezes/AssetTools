namespace AssetTool
{
    [JsonAsset("LyraGameInstance")]
    public class ULyraGameInstance : UCommonGameInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}