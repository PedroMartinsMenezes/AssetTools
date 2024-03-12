using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FPackageFileSummary& Sum)")]
    public class FPackageFileSummary
    {
        public UInt32 Tag;
        public Int32 LegacyFileVersion;
        public Int32 LegacyUE3Version;
        public FPackageFileVersion FileVersionUE = new();
        public Int32 FileVersionLicenseeUE;
        public FCustomVersionContainer CustomVersionContainer = new();
        public Int32 TotalHeaderSize;
        public FString PackageName = new();
        public UInt32 PackageFlags;
        public Int32 NameCount;
        public Int32 NameOffset;
        public Int32 SoftObjectPathsCount;
        public Int32 SoftObjectPathsOffset;
        public FString LocalizationId = new();
        public Int32 GatherableTextDataCount;
        public Int32 GatherableTextDataOffset;
        public Int32 ExportCount;
        public Int32 ExportOffset;
        public Int32 ImportCount;
        public Int32 ImportOffset;
        public Int32 DependsOffset;
        public Int32 SoftPackageReferencesCount;
        public Int32 SoftPackageReferencesOffset;
        public Int32 SearchableNamesOffset;
        public Int32 ThumbnailTableOffset;
        public FGuid Guid;
        public FGuid PersistentGuid;
        public FGuid OwnerPersistentGuid;
        public List<FGenerationInfo> Generations = new();
        public FEngineVersion SavedByEngineVersion = new();
        public FEngineVersion CompatibleWithEngineVersion = new();
        public UInt32 CompressionFlags;
        public UInt32 CompressedChunkSize;
        public UInt32 PackageSource;
        public List<FString> AdditionalPackagesToCook = [];
        public Int32 NumTextureAllocations;
        public Int32 AssetRegistryDataOffset;
        public Int64 BulkDataStartOffset;
        public Int32 WorldTileInfoDataOffset;
        public List<Int32> ChunkIDs = new();
        public Int32 PreloadDependencyCount;
        public Int32 PreloadDependencyOffset;
        public Int32 NamesReferencedFromExportDataCount;
        public Int64 PayloadTocOffset;
        public Int32 DataResourceOffset;
    }

    public static class FPackageFileSummaryExt
    {
        public static FPackageFileSummary Read(this BinaryReader reader, FPackageFileSummary item)
        {
            item = new();
            GlobalObjects.PackageFileSummary = item;

            reader.Read(ref item.Tag);
            reader.Read(ref item.LegacyFileVersion);

            if (item.LegacyFileVersion != -4)
                reader.Read(ref item.LegacyUE3Version);

            reader.Read(ref item.FileVersionUE.FileVersionUE4);

            if (item.LegacyFileVersion <= -8)
                reader.Read(ref item.FileVersionUE.FileVersionUE5);

            reader.Read(ref item.FileVersionLicenseeUE);

            if (item.LegacyFileVersion <= -2)
            {
                item.CustomVersionContainer.Versions.Resize(reader.ReadInt32());
                foreach (var version in item.CustomVersionContainer.Versions)
                {
                    reader.Read(ref version.Key);
                    reader.Read(ref version.Version);
                }
            }
            reader.Read(ref item.TotalHeaderSize);
            reader.Read(ref item.PackageName);
            reader.Read(ref item.PackageFlags);
            reader.Read(ref item.NameCount);
            reader.Read(ref item.NameOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.ADD_SOFTOBJECTPATH_LIST))
            {
                reader.Read(ref item.SoftObjectPathsCount);
                reader.Read(ref item.SoftObjectPathsOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID))
                reader.Read(ref item.LocalizationId);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES))
            {
                reader.Read(ref item.GatherableTextDataCount);
                reader.Read(ref item.GatherableTextDataOffset);
            }
            reader.Read(ref item.ExportCount);
            reader.Read(ref item.ExportOffset);
            reader.Read(ref item.ImportCount);
            reader.Read(ref item.ImportOffset);
            reader.Read(ref item.DependsOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP))
            {
                reader.Read(ref item.SoftPackageReferencesCount);
                reader.Read(ref item.SoftPackageReferencesOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_SEARCHABLE_NAMES))
                reader.Read(ref item.SearchableNamesOffset);

            reader.Read(ref item.ThumbnailTableOffset);
            reader.Read(ref item.Guid);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER))
                reader.Read(ref item.PersistentGuid);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER) && !Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT))
                reader.Read(ref item.OwnerPersistentGuid);

            item.Generations.Resize(reader.ReadInt32());
            foreach (var generation in item.Generations)
            {
                reader.Read(ref generation.ExportCount);
                reader.Read(ref generation.NameCount);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ENGINE_VERSION_OBJECT))
            {
                reader.Read(ref item.SavedByEngineVersion.Major);
                reader.Read(ref item.SavedByEngineVersion.Minor);
                reader.Read(ref item.SavedByEngineVersion.Patch);
                reader.Read(ref item.SavedByEngineVersion.Changelist);
                reader.Read(ref item.SavedByEngineVersion.Branch);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION))
            {
                reader.Read(ref item.CompatibleWithEngineVersion.Major);
                reader.Read(ref item.CompatibleWithEngineVersion.Minor);
                reader.Read(ref item.CompatibleWithEngineVersion.Patch);
                reader.Read(ref item.CompatibleWithEngineVersion.Changelist);
                reader.Read(ref item.CompatibleWithEngineVersion.Branch);
            }

            reader.Read(ref item.CompressionFlags);
            reader.Read(ref item.CompressedChunkSize);
            reader.Read(ref item.PackageSource);

            item.AdditionalPackagesToCook.Resize(reader.ReadInt32());
            for (int i = 0; i < item.AdditionalPackagesToCook.Count; i++)
            {
                item.AdditionalPackagesToCook[i] = reader.ReadFString();
            }
            if (item.LegacyFileVersion > -7)
            {
                reader.Read(ref item.NumTextureAllocations);
            }
            reader.Read(ref item.AssetRegistryDataOffset);
            reader.Read(ref item.BulkDataStartOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_WORLD_LEVEL_INFO))
                reader.Read(ref item.WorldTileInfoDataOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_CHANGED_CHUNKID_TO_BE_AN_ARRAY_OF_CHUNKIDS))
            {
                item.ChunkIDs.Resize(reader.ReadInt32());
                for (int i = 0; i < item.ChunkIDs.Count; i++)
                {
                    item.ChunkIDs[i] = reader.ReadInt32();
                }
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                reader.Read(ref item.PreloadDependencyCount);
                reader.Read(ref item.PreloadDependencyOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE5Version.NAMES_REFERENCED_FROM_EXPORT_DATA))
                reader.Read(ref item.NamesReferencedFromExportDataCount);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.PAYLOAD_TOC))
                reader.Read(ref item.PayloadTocOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.DATA_RESOURCES))
                reader.Read(ref item.DataResourceOffset);

            return item;
        }

        public static void Write(this BinaryWriter writer, FPackageFileSummary item)
        {
            writer.Write(item.Tag);
            writer.Write(item.LegacyFileVersion);

            if (item.LegacyFileVersion != -4)
                writer.Write(item.LegacyUE3Version);

            writer.Write(item.FileVersionUE.FileVersionUE4);

            if (item.LegacyFileVersion <= -8)
                writer.Write(item.FileVersionUE.FileVersionUE5);

            writer.Write(item.FileVersionLicenseeUE);

            if (item.LegacyFileVersion <= -2)
            {
                writer.Write(item.CustomVersionContainer.Versions.Count);
                foreach (var version in item.CustomVersionContainer.Versions)
                {
                    writer.Write(version.Key);
                    writer.Write(version.Version);
                }
            }
            writer.Write(item.TotalHeaderSize);
            writer.Write(item.PackageName);
            writer.Write(item.PackageFlags);
            writer.Write(item.NameCount);
            writer.Write(item.NameOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.ADD_SOFTOBJECTPATH_LIST))
            {
                writer.Write(item.SoftObjectPathsCount);
                writer.Write(item.SoftObjectPathsOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID))
                writer.Write(item.LocalizationId);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES))
            {
                writer.Write(item.GatherableTextDataCount);
                writer.Write(item.GatherableTextDataOffset);
            }
            writer.Write(item.ExportCount);
            writer.Write(item.ExportOffset);
            writer.Write(item.ImportCount);
            writer.Write(item.ImportOffset);
            writer.Write(item.DependsOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP))
            {
                writer.Write(item.SoftPackageReferencesCount);
                writer.Write(item.SoftPackageReferencesOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_SEARCHABLE_NAMES))
                writer.Write(item.SearchableNamesOffset);

            writer.Write(item.ThumbnailTableOffset);
            writer.Write(item.Guid);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER))
                writer.Write(item.PersistentGuid);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER) && !Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT))
                writer.Write(item.OwnerPersistentGuid);

            writer.Write(item.Generations.Count);
            foreach (var generation in item.Generations)
            {
                writer.Write(generation.ExportCount);
                writer.Write(generation.NameCount);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ENGINE_VERSION_OBJECT))
            {
                writer.Write(item.SavedByEngineVersion.Major);
                writer.Write(item.SavedByEngineVersion.Minor);
                writer.Write(item.SavedByEngineVersion.Patch);
                writer.Write(item.SavedByEngineVersion.Changelist);
                writer.Write(item.SavedByEngineVersion.Branch);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION))
            {
                writer.Write(item.CompatibleWithEngineVersion.Major);
                writer.Write(item.CompatibleWithEngineVersion.Minor);
                writer.Write(item.CompatibleWithEngineVersion.Patch);
                writer.Write(item.CompatibleWithEngineVersion.Changelist);
                writer.Write(item.CompatibleWithEngineVersion.Branch);
            }

            writer.Write(item.CompressionFlags);
            writer.Write(item.CompressedChunkSize);
            writer.Write(item.PackageSource);

            writer.Write(item.AdditionalPackagesToCook.Count);
            for (int i = 0; i < item.AdditionalPackagesToCook.Count; i++)
            {
                writer.Write(item.AdditionalPackagesToCook[i]);
            }
            if (item.LegacyFileVersion > -7)
            {
                writer.Write(item.NumTextureAllocations);
            }
            writer.Write(item.AssetRegistryDataOffset);
            writer.Write(item.BulkDataStartOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_WORLD_LEVEL_INFO))
                writer.Write(item.WorldTileInfoDataOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_CHANGED_CHUNKID_TO_BE_AN_ARRAY_OF_CHUNKIDS))
            {
                writer.Write(item.ChunkIDs.Count);
                for (int i = 0; i < item.ChunkIDs.Count; i++)
                {
                    writer.Write(item.ChunkIDs[i]);
                }
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                writer.Write(item.PreloadDependencyCount);
                writer.Write(item.PreloadDependencyOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE5Version.NAMES_REFERENCED_FROM_EXPORT_DATA))
                writer.Write(item.NamesReferencedFromExportDataCount);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.PAYLOAD_TOC))
                writer.Write(item.PayloadTocOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.DATA_RESOURCES))
                writer.Write(item.DataResourceOffset);
        }
    }

    #region Members
    public class FPackageFileVersion
    {
        public Int32 FileVersionUE4;
        public Int32 FileVersionUE5;
    }

    public class FCustomVersionContainer
    {
        [Sized] public List<FCustomVersion> Versions = new();
    }

    public class FCustomVersion
    {
        public FGuid Key;
        public Int32 Version;
    }

    public class FGenerationInfo
    {
        public Int32 ExportCount;
        public Int32 NameCount;
    }

    public class FEngineVersion
    {
        public UInt16 Major;
        public UInt16 Minor;
        public UInt16 Patch;
        public UInt32 Changelist;
        public FString Branch = new();
    }
    #endregion

    public class FCustomVersionJsonConverter : JsonConverter<FCustomVersion>
    {
        public override FCustomVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var x = reader.GetString()!.Split(',');
            return new FCustomVersion { Version = int.Parse(x[0]), Key = new FGuid(x[1]) };
        }

        public override void Write(Utf8JsonWriter writer, FCustomVersion value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Version}, {value.Key.Value}");
        }
    }
}
