namespace AssetTool
{
    public class FTypeResource : ITransferable
    {
        public FName TypeName;
        public FName PackageName;
        public FName ClassName;
        public FName ClassPackageName;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FTypeResource& TypeResource)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref TypeName);
            transfer.Move(ref PackageName);
            transfer.Move(ref ClassName);
            transfer.Move(ref ClassPackageName);
            return this;
        }
    }

    public class FImportTypeHierarchy : ITransferable
    {
        public int SuperTypeCount;
        public List<FTypeResource> SuperTypes;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FImportTypeHierarchy& I)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref SuperTypeCount);
            transfer.Move(ref SuperTypes, SuperTypeCount);
            return this;
        }
    }
}
