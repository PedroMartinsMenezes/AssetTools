namespace AssetTool
{
    [JsonAsset("MetaData")]
    public class UMetaData : UObject
    {
        public Dictionary<FWeakObjectPtr, Dictionary<FName, FString>> ObjectMetaDataMap;
        public Dictionary<FName, FString> RootMetaDataMap;

        [Location("void UMetaData::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref ObjectMetaDataMap);

            if (transfer.Supports.RootMetaDataSupport)
            {
                transfer.Move(ref RootMetaDataMap);
            }
            return this;
        }
    }
}
