namespace AssetTool
{
    [JsonAsset("DataTable")]
    public class UDataTable : UObject
    {
        public Dictionary<FName, UScriptStruct> RowMap;

        [Location("void UDataTable::Serialize(FStructuredArchiveRecord Record)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            LoadStructData(transfer);
            return this;
        }

        [Location("void UDataTable::LoadStructData(FStructuredArchiveSlot Slot)")]
        private void LoadStructData(Transfer transfer)
        {
            transfer.Move(ref RowMap, (value) => value.SerializeTaggedProperties(transfer));
        }
    }
}