namespace AssetTool
{
    [JsonAsset("LyraAssetManager")]
    public class ULyraAssetManager : UAssetManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}