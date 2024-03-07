namespace AssetTool
{
    public class AssetRegistryData
    {
        public int SizeOf() => FDeserializePackageData.SIZE + ObjectPackageData.Sum(x => x.SizeOf()) + TagData.SizeOf() + OutImportUsedInGame.SizeOf() + OutSoftPackageUsedInGame.SizeOf();

        public FDeserializePackageData DeserializePackageData = new();
        public List<FDeserializeObjectPackageData> ObjectPackageData = [];
        public FDeserializeTagData TagData = new();
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }

    public static class AssetRegistryDataExt
    {
        public static AssetRegistryData Read(this BinaryReader reader, AssetRegistryData item)
        {
            item ??= new();
            item.DeserializePackageData.Read(reader);

            item.ObjectPackageData.Resize(item.DeserializePackageData.ObjectCount);

            item.ObjectPackageData.ForEach(x => x.Read(reader));

            reader.Read(ref item.TagData.Key);
            reader.Read(ref item.TagData.Value);

            reader.ReadFields(item.OutImportUsedInGame);
            reader.ReadFields(item.OutSoftPackageUsedInGame);

            return item;
        }
        public static void Write(this BinaryWriter writer, AssetRegistryData item)
        {
            item.DeserializePackageData.Write(writer);

            item.ObjectPackageData.ForEach(x => x.Write(writer));

            writer.Write(item.TagData.Key);
            writer.Write(item.TagData.Value);

            writer.WriteFields(item.OutImportUsedInGame);
            writer.WriteFields(item.OutSoftPackageUsedInGame);
        }
    }

    public class FDeserializePackageData
    {
        public const int SIZE = 12;

        public Int64 DependencyDataOffset;
        public Int32 ObjectCount;

        public void Read(BinaryReader reader)
        {
            if (!PreDependencyFormat())
            {
                reader.Read(ref DependencyDataOffset);
            }
            reader.Read(ref ObjectCount);
        }

        public void Write(BinaryWriter writer)
        {
            if (!PreDependencyFormat())
            {
                writer.Write(DependencyDataOffset);
            }
            writer.Write(ObjectCount);
        }

        private static bool PreDependencyFormat()
        {
            return
            GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE4 < (int)EUnrealEngineObjectUE4Version.VER_UE4_ASSETREGISTRY_DEPENDENCYFLAGS
            ||
            (GlobalObjects.PackageFileSummary.PackageFlags & (uint)EPackageFlags.PKG_FilterEditorOnly) > 0;
        }
    }

    public class FDeserializeObjectPackageData
    {
        public int SizeOf() => ObjectPath.SizeOf() + ObjectClassName.SizeOf() + 4;

        public FString ObjectPath = new();
        public FString ObjectClassName = new();
        public Int32 TagCount;

        public void Read(BinaryReader reader)
        {
            reader.Read(ref ObjectPath);
            reader.Read(ref ObjectClassName);
            reader.Read(ref TagCount);
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(ObjectPath);
            writer.Write(ObjectClassName);
            writer.Write(TagCount);
        }
    }

    public class FDeserializeTagData
    {
        public int SizeOf() => Key.SizeOf() + Value.SizeOf();

        public FString Key = new();
        public FString Value = new();
    }
}
