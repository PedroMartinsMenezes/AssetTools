
namespace AssetTool
{
    [JsonAsset("DataTable")]
    [Location("void UDataTable::Serialize(FStructuredArchiveRecord Record)")]
    public class UDataTable : UObject
    {
        public UInt32 RowCount;

        public Dictionary<FName, UScriptStruct> RowMap = []; //HardCoded type: UScriptStruct

        public FName RowName;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            LoadStructData(transfer);
            return this;
        }

        private void LoadStructData(Transfer transfer)
        {
            RowMap.Resize(transfer);
            foreach (var pair in RowMap)
            {
                transfer.Move(pair.Key);
                pair.Value.MoveTags(transfer, pair.Value.Tags);
            }
        }
    }
}