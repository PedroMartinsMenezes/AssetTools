namespace AssetTool
{
    [JsonAsset("LyraCheatManager")]
    public class ULyraCheatManager : UCheatManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}