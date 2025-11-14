namespace AssetTool
{
    [JsonAsset("LyraHotfixManager")]
    public class ULyraHotfixManager : UOnlineHotfixManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}