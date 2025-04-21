namespace AssetTool
{
    public static class AppConfig
    {
        /// Check the bytes FPropertyTag after reading its children members
        public static bool AutoCheck { get; set; } = true;

        /// Check the bytes of every FPropertyTag child
        ///public static bool AutoCheckDeep { get; set; } = false;

        public static bool QuitOnFirstError { get; set; } = true;

        public static bool DebugAutoCheck { get; set; } = false;

        public static bool DebugUnicodeStrings { get; set; } = false;

        public static bool LogUnknownStruct { get; set; } = false;

        public static bool SaveHeader { get; set; } = false;

        public static bool SaveJson { get; set; } = false;

        public static bool SaveJsonUnitTest { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;

        public static int MaxArraySize { get; set; } = 1_000_000;

        public static int MaxFileSize { get; set; } = 100_000_000;
    }
}