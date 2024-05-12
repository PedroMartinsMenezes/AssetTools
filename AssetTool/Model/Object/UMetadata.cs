namespace AssetTool
{
    [Location("void UMetaData::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMetaData : UObject
    {
        public const string TypeName = "MetaData";

        public Dictionary<FWeakObjectPtr, Dictionary<FName, FString>> ObjectMetaDataMap = new();
        public Dictionary<FName, FString> RootMetaDataMap = new();

        public new UMetaData Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private UMetaData Read(BinaryReader reader)
        {
            #region ObjectMetaDataMap
            int count1 = reader.ReadInt32();
            for (int i = 0; i < count1; i++)
            {
                FWeakObjectPtr key1 = reader.Read(new FWeakObjectPtr());
                Dictionary<FName, FString> value1 = [];
                int count2 = key1.ObjectSerialNumber;
                for (int j = 0; j < count2; j++)
                {
                    FName key2 = new();
                    reader.Read(ref key2);
                    FString value2 = new();
                    reader.Read(ref value2);
                    value1.Add(key2, value2);
                }
                ObjectMetaDataMap.Add(key1, value1);
            }
            #endregion

            #region RootMetaDataMap
            if (Supports.CustomVer(FEditorObjectVersion.Enums.RootMetaDataSupport))
            {
                count1 = reader.ReadInt32();
                for (int i = 0; i < count1; i++)
                {
                    FName key1 = null;
                    reader.Read(ref key1);
                    FString value1 = null;
                    reader.Read(ref value1);
                    RootMetaDataMap.Add(key1, value1);
                }
            }
            #endregion

            return this;
        }
        private UMetaData Write(BinaryWriter writer)
        {
            #region ObjectMetaDataMap
            writer.Write(ObjectMetaDataMap.Count);
            foreach (var pair in ObjectMetaDataMap)
            {
                writer.Write(pair.Key);
                foreach (var pair2 in pair.Value)
                {
                    writer.Write(pair2.Key);
                    writer.Write(pair2.Value);
                }
            }
            #endregion

            #region RootMetaDataMap
            if (Supports.CustomVer(FEditorObjectVersion.Enums.RootMetaDataSupport))
            {
                writer.Write(RootMetaDataMap.Count);
                foreach (var pair in RootMetaDataMap)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
            }
            #endregion
            return this;
        }
    }
}
