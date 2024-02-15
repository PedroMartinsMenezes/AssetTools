namespace AssetTool
{
    public class FAssetImportInfo
    {
        public List<FSourceFile> SourceFiles;

        public struct FSourceFile
        {
            public FString RelativeFilename;
            public FDateTime Timestamp;
            public FMD5Hash FileHash;
            public FString DisplayLabelName;
        };
    }
}
