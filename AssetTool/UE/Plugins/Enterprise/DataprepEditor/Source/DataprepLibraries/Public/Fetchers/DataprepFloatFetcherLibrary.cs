namespace AssetTool
{
    [JsonAsset("DataprepFloatBoundingVolumeFetcher")]
    public class UDataprepFloatBoundingVolumeFetcher : UDataprepFloatFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}