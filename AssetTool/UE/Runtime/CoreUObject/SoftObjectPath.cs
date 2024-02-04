namespace AssetTool
{
    [Location("FArchive& FLinkerLoad::operator<<(FSoftObjectPath& Value)")]
    public class FSoftObjectPath
    {
        public FTopLevelAssetPath AssetPath;
        public FString SubPathString;

        public const string StructName = "SoftObjectPath";
    }

    public class FSoftClassPath : FSoftObjectPath
    {
    }
}
