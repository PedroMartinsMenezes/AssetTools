using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FPackageFileSummary : Transferible<FPackageFileSummary>
    {
        #region Members
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
        #endregion

        #region Local Variables
        public Int32 EngineChangelist;
        public Int32 ChunkID;
        #endregion

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPackageFileSummary& Sum)")]
        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Tag);
            transfer.Move(ref LegacyFileVersion);

            if (LegacyFileVersion != -4)
                transfer.Move(ref LegacyUE3Version);

            transfer.Move(ref FileVersionUE.FileVersionUE4);

            if (LegacyFileVersion <= -8)
                transfer.Move(ref FileVersionUE.FileVersionUE5);

            transfer.Move(ref FileVersionLicenseeUE);

            if (LegacyFileVersion <= -2)
            {
                CustomVersionContainer.Versions.Resize(transfer);
                foreach (var version in CustomVersionContainer.Versions)
                {
                    transfer.Move(ref version.Key);
                    transfer.Move(ref version.Version);
                }
            }
            transfer.Move(ref TotalHeaderSize);
            transfer.Move(ref PackageName);
            transfer.Move(ref PackageFlags);
            transfer.Move(ref NameCount);
            transfer.Move(ref NameOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.ADD_SOFTOBJECTPATH_LIST))
            {
                transfer.Move(ref SoftObjectPathsCount);
                transfer.Move(ref SoftObjectPathsOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID))
                transfer.Move(ref LocalizationId);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES))
            {
                transfer.Move(ref GatherableTextDataCount);
                transfer.Move(ref GatherableTextDataOffset);
            }
            transfer.Move(ref ExportCount);
            transfer.Move(ref ExportOffset);
            transfer.Move(ref ImportCount);
            transfer.Move(ref ImportOffset);
            transfer.Move(ref DependsOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP))
            {
                transfer.Move(ref SoftPackageReferencesCount);
                transfer.Move(ref SoftPackageReferencesOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_SEARCHABLE_NAMES))
                transfer.Move(ref SearchableNamesOffset);

            transfer.Move(ref ThumbnailTableOffset);
            transfer.Move(ref Guid);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER))
                transfer.Move(ref PersistentGuid);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER) && !Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT))
                transfer.Move(ref OwnerPersistentGuid);

            Generations.Resize(transfer);
            foreach (var generation in Generations)
            {
                transfer.Move(ref generation.ExportCount);
                transfer.Move(ref generation.NameCount);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ENGINE_VERSION_OBJECT))
            {
                transfer.Move(ref SavedByEngineVersion.Major);
                transfer.Move(ref SavedByEngineVersion.Minor);
                transfer.Move(ref SavedByEngineVersion.Patch);
                transfer.Move(ref SavedByEngineVersion.Changelist);
                transfer.Move(ref SavedByEngineVersion.Branch);
            }
            else
            {
                transfer.Move(ref EngineChangelist);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION))
            {
                transfer.Move(ref CompatibleWithEngineVersion.Major);
                transfer.Move(ref CompatibleWithEngineVersion.Minor);
                transfer.Move(ref CompatibleWithEngineVersion.Patch);
                transfer.Move(ref CompatibleWithEngineVersion.Changelist);
                transfer.Move(ref CompatibleWithEngineVersion.Branch);
            }

            transfer.Move(ref CompressionFlags);
            transfer.Move(ref CompressedChunkSize);
            transfer.Move(ref PackageSource);

            AdditionalPackagesToCook.Resize(transfer);
            AdditionalPackagesToCook.ForEach(x => transfer.Move(ref x));

            if (LegacyFileVersion > -7)
            {
                transfer.Move(ref NumTextureAllocations);
            }
            transfer.Move(ref AssetRegistryDataOffset);
            transfer.Move(ref BulkDataStartOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_WORLD_LEVEL_INFO))
                transfer.Move(ref WorldTileInfoDataOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_CHANGED_CHUNKID_TO_BE_AN_ARRAY_OF_CHUNKIDS))
            {
                ChunkIDs.Resize(transfer);
                ChunkIDs.ForEach(x => transfer.Move(ref x));
            }
            else if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_CHUNKID_TO_ASSETDATA_AND_UPACKAGE))
            {
                transfer.Move(ref ChunkID);
            }

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                transfer.Move(ref PreloadDependencyCount);
                transfer.Move(ref PreloadDependencyOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE5Version.NAMES_REFERENCED_FROM_EXPORT_DATA))
                transfer.Move(ref NamesReferencedFromExportDataCount);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.PAYLOAD_TOC))
                transfer.Move(ref PayloadTocOffset);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.DATA_RESOURCES))
                transfer.Move(ref DataResourceOffset);

            return this;
        }
    }

    #region Members
    public class FPackageFileVersion : ITransferible
    {
        public Int32 FileVersionUE4;
        public Int32 FileVersionUE5;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref FileVersionUE4);
            transfer.Move(ref FileVersionUE5);
            return this;
        }
    }

    public class FCustomVersionContainer : ITransferible
    {
        public List<FCustomVersion> Versions = new();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Versions);
            return this;
        }
    }

    public class FCustomVersion : ITransferible
    {
        public FGuid Key;
        public Int32 Version;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Key);
            transfer.Move(ref Version);
            return this;
        }
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
