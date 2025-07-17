namespace AssetTool
{
    [JsonAsset("LyraGameData")]
    public class ULyraGameData : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}