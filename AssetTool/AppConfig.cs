namespace AssetTool
{
    public class AppConfig
    {
        #region Debug Only
        /// Check the bytes of each Tag member read from the current AssetObject
        public bool DebugCheckMember { get; set; } = false;

        /// Save the asset Header to a json file
        public bool DebugSaveHeader { get; set; } = false;

        /// Save the JSON file from UASSET
        public bool DebugSaveJson { get; set; } = false;

        /// Save the UASSET file from JSON
        public bool DebugSaveUasset { get; set; } = false;

        /// Save the reconstructed asset to a json file
        public bool DebugSaveUnitTest { get; set; } = false;

        /// Save each Tag member from the current AssetObject
        public bool DebugSaveMember { get; set; } = false;

        /// Makes no difference on performance. Maybe consumes less memory.
        public bool DebugIgnoreAssetPackageFooter { get; set; } = false;

        /// Attempts to detect a bug when reading the FPropertyTag
        public bool BreakWhenTagSizeIsZero { get; set; } = false;

        /// Log the bytes of WorkaroundPad to discover the hidden pattern
        public bool LogWorkaroundPad { get; set; } = false;

        /// Throws an exception when a name starts with a slash
        public bool DenyNamesStartedWithSlash { get; set; } = false;
        #endregion

        #region From Appsettings
        public bool AutoCheckBinaryWriter { get; set; } = false;

        public bool ContinueAfterError { get; set; } = false;

        public bool DebugUnicodeStrings { get; set; } = false;

        public long LogStartOffset { get; set; } = 0;

        public long LogEndOffset { get; set; } = 0;

        public int MaxArraySize { get; set; } = 10_000_000;

        public int MaxStringSize { get; set; } = 10_000_000;

        public int MaxFileSize { get; set; } = 200_000_000;

        /// Use the WorkaroundPad class to read unknown bytes
        public bool UseWorkaroundPad { get; set; } = false;
        #endregion
    }
}