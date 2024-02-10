namespace AssetTool
{
    public static class GlobalObjects
    {
        public static List<FSoftObjectPath> SoftObjectPathList { get; set; } = [];

        public static List<FObjectExport> ExportMap { get; set; } = [];

        public static string ExportDiaplayValue(uint i)
        {
            if (i < ExportMap.Count)
                return ExportMap[(int)i].ObjectName.DisplayValue;
            else
                return null;
        }
    }
}
