namespace AssetTool.Model
{
    //2789..2879
    public class UMetadata : UObject
    {
        public Dictionary<FWeakObjectPtr, Dictionary<FName, FString>> ObjectMetaDataMap = new(); //2789..2830
        public Dictionary<FName, FString> RootMetaDataMap = new(); //2830..2879
    }

    public static class UMetadataExt
    {
        public static void Write(this BinaryWriter writer, UMetadata item)
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

        public static void Read(this BinaryReader reader, UMetadata item)
        {
            reader.Read((UObject)item); //2777..2789

            #region ObjectMetaDataMap 2789..2830
            int size = reader.ReadInt32();
            Enumerable.Range(0, size).ToList().ForEach(x => item.ObjectMetaDataMap.Add(new(), new()));
            foreach (var pair in item.ObjectMetaDataMap)
            {
                FWeakObjectPtr ptr = reader.Read(pair.Key);
                size = ptr.ObjectIndex;
                Enumerable.Range(0, size).ToList().ForEach(x => pair.Value.Add(new(), new()));
                foreach (var pair2 in pair.Value)
                {
                    reader.Read(pair2.Key);
                    reader.Read(pair2.Value);
                }
            }
            #endregion

            #region RootMetaDataMap 2830..2879
            size = reader.ReadInt32();
            Enumerable.Range(0, size).ToList().ForEach(x => item.RootMetaDataMap.Add(new(), new()));
            foreach (var pair in item.RootMetaDataMap)
            {
                reader.Read(pair.Key);
                reader.Read(pair.Value);
            }
            #endregion
        }
    }
}
