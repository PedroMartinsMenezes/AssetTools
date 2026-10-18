namespace AssetTool
{
    public class ImportTypeHierarchiesMap : ITransferable
    {
        public int Offset;
        public Dictionary<FPackageIndex, FImportTypeHierarchy> ImportTypeHierarchies;

        public ImportTypeHierarchiesMap() { }

        public ImportTypeHierarchiesMap(int count)
        {
            Offset = count;
        }

        public ITransferable Move(Transfer transfer)
        {
            if (Offset > 0)
                transfer.Move(ref ImportTypeHierarchies);
            return this;
        }
    }
}
