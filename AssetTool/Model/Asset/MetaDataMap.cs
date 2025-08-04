namespace AssetTool
{
    public class MetaDataMap : Transferible<MetaDataMap>
    {
        public long Size;
        public int32 NumObjectMetaDataMap;
        public int32 NumRootMetaDataMap;
        public List<TObjectMetaData> ObjectMetaData;
        public List<TRootMetaData> RootMetaData;

        public MetaDataMap() { }

        public MetaDataMap(long size)
        {
            Size = size;
        }

        [Location("FLinkerLoad::ELinkerStatus FLinkerLoad::SerializeMetaData()")]
        public override ITransferible Move(Transfer transfer)
        {
            if (Size == 0) return this;

            transfer.Move(ref NumObjectMetaDataMap);
            transfer.Move(ref NumRootMetaDataMap);

            transfer.Move(ref ObjectMetaData, NumObjectMetaDataMap);
            transfer.Move(ref RootMetaData, NumRootMetaDataMap);

            return this;
        }

        public class TObjectMetaData : ITransferible
        {
            public FSoftObjectPath Path;
            public Dictionary<FName, FString> Entries;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref Path);
                transfer.Move(ref Entries);
                return this;
            }
        }

        public class TRootMetaData : ITransferible
        {
            public FName Key;
            public FString Value;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref Key);
                transfer.Move(ref Value);
                return this;
            }
        }
    }
}
