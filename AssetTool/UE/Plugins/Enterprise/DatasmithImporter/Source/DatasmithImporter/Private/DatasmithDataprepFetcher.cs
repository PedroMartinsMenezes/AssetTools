namespace AssetTool
{
    [JsonAsset("DatasmithStringMetadataValueFetcher")]
    public class UDatasmithStringMetadataValueFetcher : UDataprepStringsArrayFetcher
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}