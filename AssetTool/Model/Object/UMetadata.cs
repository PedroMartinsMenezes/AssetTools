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

            ObjectMetaDataMap.Resize(transfer);
            foreach (var pair in ObjectMetaDataMap)
            {
                pair.Key.Move2(transfer);
                pair.Value.Resize(transfer, pair.Key.ObjectSerialNumber);
                foreach (var pair2 in pair.Value)
                {
                    pair2.Key.Move2(transfer);
                    pair2.Value.Move2(transfer);
                }
            }

            if (transfer.Supports.RootMetaDataSupport)
            {
                transfer.Move(ref RootMetaDataMap);
            }
            return this;
        }
    }
}
