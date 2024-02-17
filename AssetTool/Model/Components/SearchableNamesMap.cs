namespace AssetTool
{
    [Location("Record << SA_VALUE(TEXT(\"SearchableNamesOffset\"), Sum.SearchableNamesOffset);")]
    public class SearchableNamesMap
    {
        public int SizeOf() => 4 + Map.Count * FPackageIndex.SIZE + Map.Values.Cast<NameList>().Sum(x => x.SizeOf());

        public TMap1<FPackageIndex, NameList> Map = new();

        public class NameList
        {
            public int SizeOf() => 4 + List.Sum(x => FName.SIZE);

            [Sized] public List<FName> List = new();
        }
    }
}
