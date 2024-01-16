namespace AssetTool
{
    //[1] 2681..2777
    public class AssetRegistryData
    {
        public FDeserializePackageData DeserializePackageData;
        public FDeserializeObjectPackageData ObjectPackageData;
        public FDeserializeTagData TagData;
        public TBitArray OutImportUsedInGame;
        public TBitArray OutSoftPackageUsedInGame;
    }

    public class FDeserializePackageData
    {
        public Int64 DependencyDataOffset;
        public Int32 ObjectCount;
    }

    public class FDeserializeObjectPackageData
    {
        public FString ObjectPath;
        public FString ObjectClassName;
        public Int32 TagCount;
    }

    public class FDeserializeTagData
    {
        public FString Key;
        public FString Value;
    }
}
