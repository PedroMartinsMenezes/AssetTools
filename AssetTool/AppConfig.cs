namespace AssetTool
{
    public static class AppConfig
    {
        /// Check the bytes FPropertyTag after reading its children members
        public static bool AutoCheck { get; set; } = false;

        /// Check the bytes of every FPropertyTag child
        public static bool AutoCheckDeep { get; set; } = false;

        public static bool DebugAutoCheck { get; set; } = false;

        public static bool DebugUnicodeStrings { get; set; } = false;

        public static bool LogUnknownStruct { get; set; } = false;

        public static bool SaveHeader { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;

        public static int MaxArraySize { get; set; } = 100000;
    }
}