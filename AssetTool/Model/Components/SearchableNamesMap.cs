namespace AssetTool
{
    [Location("Record << SA_VALUE(TEXT(\"SearchableNamesOffset\"), Sum.SearchableNamesOffset);")]
    public class SearchableNamesMap
    {
        public TMap1<FPackageIndex, NameList> Map = new();

        public class NameList
        {
            [Sized] public List<FName> List = new();
        }
    }
}
