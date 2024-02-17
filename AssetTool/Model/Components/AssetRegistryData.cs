namespace AssetTool
{
    public class AssetRegistryData
    {
        public int SizeOf() => FDeserializePackageData.SIZE + ObjectPackageData.SizeOf() + TagData.SizeOf() + OutImportUsedInGame.SizeOf() + OutSoftPackageUsedInGame.SizeOf();

        public FDeserializePackageData DeserializePackageData;
        public FDeserializeObjectPackageData ObjectPackageData;
        public FDeserializeTagData TagData;
        public TBitArray OutImportUsedInGame;
        public TBitArray OutSoftPackageUsedInGame;
    }

    public class FDeserializePackageData
    {
        public const int SIZE = 12;

        public Int64 DependencyDataOffset;
        public Int32 ObjectCount;
    }

    public class FDeserializeObjectPackageData
    {
        public int SizeOf() => ObjectPath.SizeOf() + ObjectClassName.SizeOf() + 4;

        public FString ObjectPath;
        public FString ObjectClassName;
        public Int32 TagCount;
    }

    public class FDeserializeTagData
    {
        public int SizeOf() => Key.SizeOf() + Value.SizeOf();

        public FString Key;
        public FString Value;
    }
}
