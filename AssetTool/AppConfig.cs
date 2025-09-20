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

        /// Save the UASSET file from JSON
        public static bool DebugSaveUasset { get; set; } = false;

        /// Save the reconstructed asset to a json file
        public static bool DebugSaveUnitTest { get; set; } = false;

        /// Save each Tag member from the current AssetObject
        public static bool DebugSaveMember { get; set; } = false;

        /// Makes no difference on performance. Maybe consumes less memory.
        public static bool DebugIgnoreAssetPackageFooter { get; set; } = false;

        /// Attempts to detect a bug when reading the FPropertyTag
        public static bool BreakWhenTagSizeIsZero { get; set; } = false;

        /// Log the bytes of WorkaroundPad to discover the hidden pattern
        public static bool LogWorkaroundPad { get; set; } = false;

        /// Throws an exception when a name starts with a slash
        public static bool DenyNamesStartedWithSlash { get; set; } = false;
        #endregion

        #region From Appsettings
        public static bool AutoCheckBinaryWriter { get; set; } = false;

        public static bool ContinueAfterError { get; set; } = false;

        public static bool DebugUnicodeStrings { get; set; } = false;

        public static bool LogUnknownStruct { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;

        public static int MaxArraySize { get; set; } = 10_000_000;

        public static int MaxStringSize { get; set; } = 10_000_000;

        public static int MaxFileSize { get; set; } = 100_000_000;

        /// Use the WorkaroundPad class to read unknown bytes
        public static bool UseWorkaroundPad { get; set; } = false;
        #endregion
    }
}