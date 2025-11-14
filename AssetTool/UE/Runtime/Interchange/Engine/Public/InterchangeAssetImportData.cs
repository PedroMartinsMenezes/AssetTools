namespace AssetTool
{
    [JsonAsset("InterchangeAssetImportData")]
    public class UInterchangeAssetImportData : UAssetImportData
    {
        public TArray64<TUInt8> CachedNodeContainer;
        public Dictionary<FString, FString> CachedPipelines;

        [Location("void UInterchangeAssetImportData::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.SerializedInterchangeObjectStoring)
            {
                transfer.Move(ref CachedNodeContainer);
                transfer.Move(ref CachedPipelines);
            }
            return this;
        }
    }

    [JsonAsset("InterchangeAssetImportDataConverterBase")]
    public class UInterchangeAssetImportDataConverterBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}