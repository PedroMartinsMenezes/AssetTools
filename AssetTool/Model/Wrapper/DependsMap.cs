namespace AssetTool
{
    //2608..2620
    public class DependsMap
    {
        public List<PackageIndexes> Map;

        public class PackageIndexes
        {
            [Sized] public List<FPackageIndex> Indices;
        }
    }
}
