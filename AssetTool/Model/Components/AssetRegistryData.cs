namespace AssetTool
{
    public class AssetRegistryData
    {
        public int SizeOf() => FDeserializePackageData.SIZE + ObjectPackageData.SizeOf() + TagData.SizeOf() + OutImportUsedInGame.SizeOf() + OutSoftPackageUsedInGame.SizeOf();

        public FDeserializePackageData DeserializePackageData = new();
        public FDeserializeObjectPackageData ObjectPackageData = new();
        public FDeserializeTagData TagData = new();
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }

    public static class AssetRegistryDataExt
    {
        public static void Write(this BinaryWriter writer, AssetRegistryData item)
        {
            writer.Write(item.DeserializePackageData.DependencyDataOffset);
            writer.Write(item.DeserializePackageData.ObjectCount);

            writer.Write(item.ObjectPackageData.ObjectPath);
            writer.Write(item.ObjectPackageData.ObjectClassName);
            writer.Write(item.ObjectPackageData.TagCount);

            writer.Write(item.TagData.Key);
            writer.Write(item.TagData.Value);

            writer.WriteFields(item.OutImportUsedInGame);
            writer.WriteFields(item.OutSoftPackageUsedInGame);
        }

        public static AssetRegistryData Read(this BinaryReader reader, AssetRegistryData item)
        {
            item ??= new();
            reader.Read(ref item.DeserializePackageData.DependencyDataOffset);
            reader.Read(ref item.DeserializePackageData.ObjectCount);

            reader.Read(ref item.ObjectPackageData.ObjectPath);
            reader.Read(ref item.ObjectPackageData.ObjectClassName);
            reader.Read(ref item.ObjectPackageData.TagCount);

            reader.Read(ref item.TagData.Key);
            reader.Read(ref item.TagData.Value);

            reader.ReadFields(item.OutImportUsedInGame);
            reader.ReadFields(item.OutSoftPackageUsedInGame);

            return item;
        }
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

        public FString ObjectPath = new();
        public FString ObjectClassName = new();
        public Int32 TagCount;
    }

    public class FDeserializeTagData
    {
        public int SizeOf() => Key.SizeOf() + Value.SizeOf();

        public FString Key = new();
        public FString Value = new();
    }
}
