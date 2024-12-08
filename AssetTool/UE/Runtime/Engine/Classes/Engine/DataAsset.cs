namespace AssetTool
{
    [JsonAsset("DataAsset")]
    public class UDataAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PrimaryDataAsset")]
    public class UPrimaryDataAsset : UDataAsset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}