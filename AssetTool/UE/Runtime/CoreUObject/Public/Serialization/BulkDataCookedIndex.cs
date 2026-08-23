namespace AssetTool
{
    public class FBulkDataCookedIndex : ITransferable
    {
        public uint8 Value;

        [Location("friend void operator<<(FStructuredArchive::FSlot Slot, FBulkDataCookedIndex& ChunkGroup)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
