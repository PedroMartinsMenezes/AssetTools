namespace AssetTool
{
    [JsonAsset("LyraSettingsShared")]
    public class ULyraSettingsShared : ULocalPlayerSaveGame
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}