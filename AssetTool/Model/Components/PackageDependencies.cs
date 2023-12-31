namespace AssetTool
{
    //[1] 2681..2765
    public class PackageDependencies
    {
        public UInt32[] Pad1 = new UInt32[3]; //2608..2620

        public List<UInt32> Pad2 = new List<UInt32>(); //2620..2624

        public FDeserializePackageData DeserializePackageData = new();
        public FDeserializeObjectPackageData ObjectPackageData = new();
        public FDeserializeTagData TagData = new();
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }

    public class FDeserializePackageData
    {
        public Int64 DependencyDataOffset;
        public Int32 ObjectCount;
    }

    public class FDeserializeObjectPackageData
    {
        public FString ObjectPath = new();
        public FString ObjectClassName = new();
        public Int32 TagCount;
    }

    public class FDeserializeTagData
    {
        public FString Key = new();
        public FString Value = new();
    }

    public static class PackageDataMainExt
    {
        public static void Write(this BinaryWriter writer, PackageDependencies item)
        {
            if (item is null) return;
            writer.Write(item.DeserializePackageData.DependencyDataOffset);
            writer.Write(item.DeserializePackageData.ObjectCount);
            writer.Write(item.ObjectPackageData.ObjectPath);
            writer.Write(item.ObjectPackageData.ObjectClassName);
            writer.Write(item.ObjectPackageData.TagCount);
            writer.Write(item.TagData.Key);
            writer.Write(item.TagData.Value);
            writer.Write(item.OutImportUsedInGame);
            writer.Write(item.OutSoftPackageUsedInGame);
        }

        public static PackageDependencies Read(this BinaryReader reader, PackageDependencies item)
        {
            reader.Read(ref item.DeserializePackageData.DependencyDataOffset);
            reader.Read(ref item.DeserializePackageData.ObjectCount);
            reader.Read(ref item.ObjectPackageData.ObjectPath);
            reader.Read(ref item.ObjectPackageData.ObjectClassName);
            reader.Read(ref item.ObjectPackageData.TagCount);
            reader.Read(ref item.TagData.Key);
            reader.Read(ref item.TagData.Value);
            reader.Read(item.OutImportUsedInGame);
            reader.Read(item.OutSoftPackageUsedInGame);
            return item;
        }
    }
}
