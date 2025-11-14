namespace AssetTool
{
    [JsonAsset("LyraAssetManager")]
    public class ULyraAssetManager : UAssetManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}