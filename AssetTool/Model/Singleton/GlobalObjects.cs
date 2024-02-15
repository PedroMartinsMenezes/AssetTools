namespace AssetTool
{
    public static class GlobalObjects
    {
        public static FPackageFileSummary PackageFileSummary { get; set; }

        public static List<FSoftObjectPath> SoftObjectPathList { get; set; } = [];

        public static List<FObjectExport> ExportMap { get; set; } = [];

        public static string ExportDiaplayValue(uint i)
        {
            if (i < ExportMap.Count)
                return ExportMap[(int)i].ObjectName.DisplayValue;
            else
                return null;
        }

        public static bool UESupport(EUnrealEngineObjectUE4Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE4 >= (int)value;
        }

        public static bool UESupport(EUnrealEngineObjectUE5Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE5 >= (int)value;
        }
    }
}
