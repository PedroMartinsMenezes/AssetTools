namespace AssetTool
{
    //2608..2620
    public class DependsMap
    {
        public List<PackageIndexes> Map;

        public class PackageIndexes
        {
            [TArray] public List<FPackageIndex> Indices;
        }
    }
}
