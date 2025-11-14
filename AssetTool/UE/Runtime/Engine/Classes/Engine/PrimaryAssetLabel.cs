namespace AssetTool
{
    [JsonAsset("PrimaryAssetLabel")]
    public class UPrimaryAssetLabel : UPrimaryDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}