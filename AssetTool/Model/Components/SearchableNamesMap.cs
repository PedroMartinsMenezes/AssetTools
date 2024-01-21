namespace AssetTool
{
    //2620..2624
    public class SearchableNamesMap
    {
        public TMap1<FPackageIndex, NameList> Map = new();

        [Sized]
        public class NameList
        {
            public List<FName> List = new();
        }
    }
}
