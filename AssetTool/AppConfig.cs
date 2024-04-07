namespace AssetTool
{
    public static class AppConfig
    {
        public static bool AutoCheck { get; set; } = true;

        public static bool EnableVerboseLog { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;
    }
}