namespace AssetTool
{
    [JsonAsset("LyraHotfixManager")]
    public class ULyraHotfixManager : UOnlineHotfixManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}