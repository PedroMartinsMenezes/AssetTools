namespace AssetTool
{
    [JsonAsset("InterchangeAssetImportData")]
    public class UInterchangeAssetImportData : UAssetImportData
    {
        public TArray64<TUInt8> CachedNodeContainer;
        public Dictionary<FString, FString> CachedPipelines;

        [Location("void UInterchangeAssetImportData::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.SerializedInterchangeObjectStoring)
            {
                transfer.Move(ref CachedNodeContainer);
                transfer.Move(ref CachedPipelines);
            }
            return this;
        }
    }
}