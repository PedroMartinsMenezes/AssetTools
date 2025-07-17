namespace AssetTool
{
    [JsonAsset("LyraCheatManager")]
    public class ULyraCheatManager : UCheatManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}