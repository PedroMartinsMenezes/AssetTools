namespace AssetTool
{
    public static class AppConfig
    {
        public static bool AutoCheck { get; set; } = true;

        public static bool DebugAutoCheck { get; set; } = false;

        public static bool DebugUnicodeStrings { get; set; } = false;

        public static bool LogUnknownStruct { get; set; } = true;

        public static bool RedundantAutoCheck { get; set; } = false;

        public static bool SaveHeader { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;

        public static int MaxArraySize { get; set; } = 100000;
    }
}