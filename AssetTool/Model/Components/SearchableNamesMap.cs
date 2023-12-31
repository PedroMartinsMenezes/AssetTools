namespace AssetTool
{
    //2620..2636
    //TMap<FPackageIndex, TArray<FName> >
    public class SearchableNamesMap
    {
        public byte[] Gap = new byte[16];
    }

    public static class SearchableNamesMapExt
    {
        public static void Write(this BinaryWriter writer, SearchableNamesMap item)
        {
            if (item is null) return;
        }

        public static SearchableNamesMap Read(this BinaryReader reader, SearchableNamesMap item)
        {
            return item;
        }
    }
}
