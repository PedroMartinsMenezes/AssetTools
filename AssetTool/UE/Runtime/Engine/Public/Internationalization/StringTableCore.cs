namespace AssetTool
{
    using FMetaDataMap = Dictionary<FName, FString>;

    public class FStringTable : ITransferable
    {
        public FString TableNamespace;
        public List<TableEntry> TableEntries;
        public Dictionary<FString, FMetaDataMap> TmpKeysToMetaData;

        [Location("void FStringTable::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref TableNamespace);
            transfer.Move(ref TableEntries);
            transfer.Move(ref TmpKeysToMetaData);
            return this;
        }

        public class TableEntry : ITransferable
        {
            public FString Key;
            public FString SourceString;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Key);
                transfer.Move(ref SourceString);
                return this;
            }
        }
    }
}