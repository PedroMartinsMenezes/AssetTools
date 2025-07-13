namespace AssetTool
{
    [JsonAsset("DatasmithStringMetadataValueFetcher")]
    public class UDatasmithStringMetadataValueFetcher : UDataprepStringsArrayFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}