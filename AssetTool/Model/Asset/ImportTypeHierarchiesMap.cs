namespace AssetTool
{
    public class ImportTypeHierarchiesMap : ITransferable
    {
        public int Count;
        public Dictionary<FPackageIndex, FImportTypeHierarchy> ImportTypeHierarchies;

        public ImportTypeHierarchiesMap() { }

        public ImportTypeHierarchiesMap(int count)
        {
            Count = count;
        }

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ImportTypeHierarchies, Count);
            return this;
        }
    }
}
