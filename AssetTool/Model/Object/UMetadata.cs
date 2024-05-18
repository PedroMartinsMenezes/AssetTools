namespace AssetTool
{
    [Location("void UMetaData::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMetaData : UObject
    {
        public const string TypeName = "MetaData";

        public Dictionary<FWeakObjectPtr, Dictionary<FName, FString>> ObjectMetaDataMap = new();
        public Dictionary<FName, FString> RootMetaDataMap = new();

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            #region ObjectMetaDataMap
            ObjectMetaDataMap.Resize(transfer);
            foreach (var pair in ObjectMetaDataMap)
            {
                pair.Key.Move(transfer);
                pair.Value.Resize(pair.Key.ObjectSerialNumber);
                Dictionary<FName, FString> value1 = pair.Value;

                foreach (var pair1 in value1)
                {
                    transfer.Move(pair1.Key);
                    transfer.Move(pair1.Value);
                }
            }
            #endregion

            #region RootMetaDataMap
            if (Supports.CustomVer(FEditorObjectVersion.Enums.RootMetaDataSupport))
            {
                RootMetaDataMap.Resize(transfer);
                foreach (var pair2 in RootMetaDataMap)
                {
                    transfer.Move(pair2.Key);
                    transfer.Move(pair2.Value);
                }
            }
            #endregion

            return this;
        }
    }
}
