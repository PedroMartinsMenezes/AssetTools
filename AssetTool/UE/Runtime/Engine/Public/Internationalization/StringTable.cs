namespace AssetTool
{
    [JsonAsset("StringTable")]
    public class UStringTable : UObject
    {
        public FStringTable StringTable;

        [Location("void UStringTable::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StringTable);
            return this;
        }
    }
}