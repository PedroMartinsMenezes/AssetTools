namespace AssetTool
{
    [JsonAsset("LyraPawnData")]
    public class ULyraPawnData : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}