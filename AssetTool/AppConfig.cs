namespace AssetTool
{
    public static class AppConfig
    {
        public static bool AutoCheck { get; set; } = true;

        public static bool LogUnknownStruct { get; set; } = true;

        public static bool RedundantAutoCheck { get; set; } = true;

        public static bool EnableVerboseLog { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;

        public static int[] IgnoredObjects { get; set; } = [0];

        public static int MaxArraySize { get; set; } = 10000;
    }
}