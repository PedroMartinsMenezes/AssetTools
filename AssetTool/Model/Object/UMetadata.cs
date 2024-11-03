namespace AssetTool
{
    [JsonAsset("MetaData")]
    public class UMetaData : UObject
    {
        public Dictionary<FWeakObjectPtr, Dictionary<FName, FString>> ObjectMetaDataMap = new();
        public Dictionary<FName, FString> RootMetaDataMap = new();

        [Location("void UMetaData::Serialize(FStructuredArchive::FRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            //TODO move to Transfer
            ObjectMetaDataMap.Move(transfer,
                (key) => key.Move(transfer),
                (key, value) => value.Move(transfer,
                    key.ObjectSerialNumber,
                    (key) => transfer.Move(key),
                    (value) => transfer.Move(value)));

            if (Supports.CustomVer(FEditorObjectVersion.Enums.RootMetaDataSupport))
            {
                transfer.Move(ref RootMetaDataMap);
            }
            return this;
        }
    }
}
