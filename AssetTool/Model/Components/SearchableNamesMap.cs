namespace AssetTool
{
    //2620..2624
    public class SearchableNamesMap
    {
        public TMap1<FPackageIndex, NameList> Map = new();

        public class NameList
        {
            [Sized] public List<FName> List = new();
        }
    }
}
