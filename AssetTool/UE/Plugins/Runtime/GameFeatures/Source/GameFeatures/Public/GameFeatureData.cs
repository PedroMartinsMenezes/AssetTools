namespace AssetTool
{
    [JsonAsset("GameFeatureData")]
    public class UGameFeatureData : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}