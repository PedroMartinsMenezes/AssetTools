namespace AssetTool
{
    [JsonAsset("PrimaryAssetLabel")]
    public class UPrimaryAssetLabel : UPrimaryDataAsset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}