namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FImportTypeHierarchy& I)")]
    public class FImportTypeHierarchy : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            return this;
        }
    }
}
