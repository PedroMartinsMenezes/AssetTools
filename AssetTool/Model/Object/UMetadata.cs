namespace AssetTool
{
    [JsonAsset("MetaData")]
    public class UMetaData : UObject
    {
        public const string TypeName = "MetaData";

        public Dictionary<FWeakObjectPtr, Dictionary<FName, FString>> ObjectMetaDataMap = new();
        public Dictionary<FName, FString> RootMetaDataMap = new();

        [Location("void UMetaData::Serialize(FStructuredArchive::FRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            ObjectMetaDataMap.Move(transfer,
                (key) => key.Move(transfer),
                (key, value) => value.Move(transfer,
                    key.ObjectSerialNumber,
                    (key) => transfer.Move(key),
                    (value) => transfer.Move(value)));

            if (Supports.CustomVer(FEditorObjectVersion.Enums.RootMetaDataSupport))
                RootMetaDataMap.Move(transfer, (key) => transfer.Move(key), (value) => transfer.Move(value));

            return this;
        }
    }
}
