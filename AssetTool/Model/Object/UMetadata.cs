namespace AssetTool
{
    [Location("void UMetaData::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMetaData : UObject
    {
        public const string TypeName = "MetaData";

        public Dictionary<FWeakObjectPtr, Dictionary<FName, FString>> ObjectMetaDataMap = new();
        public Dictionary<FName, FString> RootMetaDataMap = new();
    }

    public static class UMetadataExt
    {
        public static void Write(this BinaryWriter writer, UMetaData item)
        {
            writer.Write((UObject)item);

            #region ObjectMetaDataMap 2789..2830
            writer.Write(item.ObjectMetaDataMap.Count);
            foreach (var pair in item.ObjectMetaDataMap)
            {
                writer.Write(pair.Key);
                foreach (var pair2 in pair.Value)
                {
                    writer.Write(pair2.Key);
                    writer.Write(pair2.Value);
                }
            }
            #endregion

            #region RootMetaDataMap 2830..2879
            writer.Write(item.RootMetaDataMap.Count);
            foreach (var pair in item.RootMetaDataMap)
            {
                writer.Write(pair.Key);
                writer.Write(pair.Value);
            }
            #endregion
        }

        public static void Read(this BinaryReader reader, UMetaData item)
        {
            reader.Read((UObject)item);

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
                item.ObjectMetaDataMap.Add(key1, value1);
            }
            #endregion

            #region RootMetaDataMap
            count1 = reader.ReadInt32();
            for (int i = 0; i < count1; i++)
            {
                FName key1 = null;
                reader.Read(ref key1);
                FString value1 = null;
                reader.Read(ref value1);
                item.RootMetaDataMap.Add(key1, value1);
            }
            #endregion
        }
    }
}
