namespace AssetTool
{
    [JsonAsset("DataTable")]
    public class UDataTable : UObject
    {
        public UInt32 RowCount;

        public Dictionary<FName, UScriptStruct> RowMap = [];

        public FName RowName;

        [Location("void UDataTable::Serialize(FStructuredArchiveRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            LoadStructData(transfer);
            return this;
        }

        private void LoadStructData(Transfer transfer)
        {
            RowMap.Move(transfer, (key) => transfer.Move(key), (value) => value.SerializeTaggedProperties(transfer));
        }
    }
}