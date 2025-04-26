namespace AssetTool
{
    public static class AppConfig
    {
        #region Debug Only
        /// Save the asset Header to a json file
        public static bool DebugSaveHeader { get; set; } = false;

        // Save the reconstructed asset to a json file
        public static bool DebugSaveReconstructed { get; set; } = false;

        /// Save the reconstructed asset to a json file
        public static bool DebugSaveUnitTest { get; set; } = true;

        /// Save each Tag member from the current AssetObject
        public static bool DebugSaveMember { get; set; } = false;

        /// Check the bytes of each Tag member read from the current AssetObject
        public static bool DebugCheckMember { get; set; } = false;
        #endregion

        public static bool DebugUnicodeStrings { get; set; } = false;

        public static bool LogUnknownStruct { get; set; } = false;

        public static long LogStartOffset { get; set; } = 0;

        public static long LogEndOffset { get; set; } = 0;

        public static int MaxArraySize { get; set; } = 10_000_000;
    }
}