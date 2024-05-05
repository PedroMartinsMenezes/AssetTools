namespace AssetTool
{
    public class AssetRegistryData
    {
        public int SizeOf() => DeserializePackageData.SizeOf() + (DeserializePackageData.DependencyDataOffset == -1 ? 0 : PackageDependencyData.SizeOf());

        public FDeserializePackageData DeserializePackageData = new();

        public FPackageDependencyData PackageDependencyData = new();
    }

    public static class AssetRegistryDataExt
    {
        public static AssetRegistryData Read(this BinaryReader reader, AssetRegistryData item)
        {
            item ??= new();
            item.DeserializePackageData.Read(reader);
            if (item.DeserializePackageData.DependencyDataOffset != -1)
            {
                item.PackageDependencyData.Read(reader);
            }
            return item;
        }

        public static void Write(this BinaryWriter writer, AssetRegistryData item)
        {
            item.DeserializePackageData.Write(writer);
            if (item.DeserializePackageData.DependencyDataOffset != -1)
            {
                item.PackageDependencyData.Write(writer);
            }
        }
    }

    #region FDeserializePackageData
    [Location("bool FDeserializePackageData::DoSerialize(FArchive& BinaryArchive, const FPackageFileSummary& PackageFileSummary")]
    public class FDeserializePackageData
    {
        public int SizeOf() => (DependencyDataOffset == -1 ? 0 : 8) + 4 + ObjectPackageData.Sum(x => x.SizeOf());

        public Int64 DependencyDataOffset = -1;
        public Int32 ObjectCount;
        public List<FDeserializeObjectPackageData> ObjectPackageData = [];

        public void Read(BinaryReader reader)
        {
            if (!PreDependencyFormat())
            {
                reader.Read(ref DependencyDataOffset);
            }
            reader.Read(ref ObjectCount);

            ObjectPackageData.Resize(ObjectCount);
            ObjectPackageData.ForEach(x => x.Read(reader));
        }

        public void Write(BinaryWriter writer)
        {
            if (!PreDependencyFormat())
            {
                writer.Write(DependencyDataOffset);
            }
            writer.Write(ObjectCount);
            ObjectPackageData.ForEach(x => x.Write(writer));
        }

        private static bool PreDependencyFormat()
        {
            return
            GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE4 < (int)EUnrealEngineObjectUE4Version.VER_UE4_ASSETREGISTRY_DEPENDENCYFLAGS
            ||
            (GlobalObjects.PackageFileSummary.PackageFlags & (uint)EPackageFlags.PKG_FilterEditorOnly) > 0;
        }
    }

    [Location("bool FDeserializeObjectPackageData::DoSerialize(FArchive& BinaryArchive")]
    public class FDeserializeObjectPackageData
    {
        public int SizeOf() => ObjectPath.SizeOf() + ObjectClassName.SizeOf() + 4 + TagsAndValues.Sum(x => x.Key.SizeOf() + x.Value.SizeOf());

        public FString ObjectPath = new();
        public FString ObjectClassName = new();
        public Int32 TagCount;
        public Dictionary<FString, FString> TagsAndValues = new();

        public void Read(BinaryReader reader)
        {
            reader.Read(ref ObjectPath);
            reader.Read(ref ObjectClassName);
            reader.Read(ref TagCount);
            for (int i = 0; i < TagCount; i++)
            {
                FString key = reader.ReadFString();
                FString value = reader.ReadFString();
                TagsAndValues.Add(key, value);
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(ObjectPath);
            writer.Write(ObjectClassName);
            writer.Write(TagCount);
            foreach (var tag in TagsAndValues)
            {
                writer.Write(tag.Key);
                writer.Write(tag.Value);
            }
        }
    }

    public class FDeserializeTagData
    {
        public int SizeOf() => Key.SizeOf() + Value.SizeOf();

        public FString Key = new();
        public FString Value = new();

        public FDeserializeTagData Read(BinaryReader reader)
        {
            reader.Read(ref Key);
            reader.Read(ref Value);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(Key);
            writer.Write(Value);
        }
    }
    #endregion

    public class FPackageDependencyData
    {
        public int SizeOf() => OutImportUsedInGame.SizeOf() + OutSoftPackageUsedInGame.SizeOf();

        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();

        public FPackageDependencyData Read(BinaryReader reader)
        {
            OutImportUsedInGame.Read(reader);
            OutSoftPackageUsedInGame.Read(reader);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            OutImportUsedInGame.Write(writer);
            OutSoftPackageUsedInGame.Write(writer);
        }
    }
}
