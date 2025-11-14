namespace AssetTool
{
    [JsonAsset("LyraTextHotfixConfig")]
    public class ULyraTextHotfixConfig : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}