namespace AssetTool
{
    public static class AppConfig
    {
        #region Debug Only
        /// Check the bytes of each Tag member read from the current AssetObject
        public static bool DebugCheckMember { get; set; } = false;

        /// Save the JSON file from UASSET
        public static bool DebugSaveJson { get; set; } = false;

        /// Save the asset Header to a json file
        public static bool DebugSaveHeader { get; set; } = false;

        // Save the UASSET file from JSON
        public static bool DebugSaveUasset { get; set; } = false;

        /// Save the reconstructed asset to a json file
        public static bool DebugSaveUnitTest { get; set; } = false;

        /// Save each Tag member from the current AssetObject
        public static bool DebugSaveMember { get; set; } = false;

        public static bool DebugIgnoreJsonPadData { get; set; } = false;

        public static bool BreakWhenTagSizeIsZero { get; set; } = false;
        #endregion

        #region From Appsettings
        public static bool AutoCheckBinaryWriter { get; set; } = false;

        public static bool ContinueAfterError { get; set; } = false;

        public static bool DebugUnicodeStrings { get; set; } = false;

        public static bool LogUnknownStruct { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;

        public static int MaxArraySize { get; set; } = 1_000_000;

        public static int MaxStringSize { get; set; } = 10_000_000;

        public static int MaxFileSize { get; set; } = 100_000_000;
        #endregion
    }
}