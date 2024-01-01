namespace AssetTool
{
    //[1] 2681..2765
    public class AssetRegistryData
    {
        public FDeserializePackageData DeserializePackageData = new(); //2681..2693
        public FDeserializeObjectPackageData ObjectPackageData = new(); //2693..2749
        public FDeserializeTagData TagData = new(); //2749..2765

        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }

    public class FDeserializePackageData
    {
        public Int64 DependencyDataOffset; //2765
        public Int32 ObjectCount; //1
    }

    public class FDeserializeObjectPackageData
    {
        public FString ObjectPath = new(); //"S_Endereco"
        public FString ObjectClassName = new(); //"/Script/Engine.UserDefinedStruct"
        public Int32 TagCount; //1
    }

    public class FDeserializeTagData
    {
        public FString Key = new(); //"Tooltip"
        public FString Value = new(); //""
    }

    public static class PackageDataMainExt
    {
        public static void Write(this BinaryWriter writer, AssetRegistryData item)
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

        public static AssetRegistryData ReadAssetRegistryData(this BinaryReader reader, int offset)
        {
            reader.BaseStream.Position = offset;
            var item = new AssetRegistryData();
            reader.Read(ref item.DeserializePackageData.DependencyDataOffset);
            reader.Read(ref item.DeserializePackageData.ObjectCount);
            reader.Read(item.ObjectPackageData.ObjectPath);
            reader.Read(item.ObjectPackageData.ObjectClassName);
            reader.Read(ref item.ObjectPackageData.TagCount);
            reader.Read(item.TagData.Key);
            reader.Read(item.TagData.Value);
            reader.Read(item.OutImportUsedInGame);
            reader.Read(item.OutSoftPackageUsedInGame);
            return item;
        }
    }
}
