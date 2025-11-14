namespace AssetTool
{
    [JsonAsset("GameFeatureData")]
    public class UGameFeatureData : UPrimaryDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}