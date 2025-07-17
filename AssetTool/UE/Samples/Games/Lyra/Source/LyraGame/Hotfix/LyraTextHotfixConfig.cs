namespace AssetTool
{
    [JsonAsset("LyraTextHotfixConfig")]
    public class ULyraTextHotfixConfig : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}