namespace AssetTool
{
    [JsonAsset("PrimaryAssetLabel")]
    public class UPrimaryAssetLabel : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}