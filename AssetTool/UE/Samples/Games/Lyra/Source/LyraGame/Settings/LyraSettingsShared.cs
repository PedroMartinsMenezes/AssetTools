namespace AssetTool
{
    [JsonAsset("LyraSettingsShared")]
    public class ULyraSettingsShared : ULocalPlayerSaveGame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}