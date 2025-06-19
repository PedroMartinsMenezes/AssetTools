using System.Diagnostics;
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
        public EPackageFlags PackageFlags;
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
        public List<FGenerationInfo> Generations;
        public FEngineVersion SavedByEngineVersion;
        public FEngineVersion CompatibleWithEngineVersion;
        public UInt32 CompressionFlags;
        public UInt32 CompressedChunkSize;
        public UInt32 PackageSource;
        public List<FString> AdditionalPackagesToCook;
        public Int32 NumTextureAllocations;
        public Int32 AssetRegistryDataOffset;
        public Int64 BulkDataStartOffset;
        public Int32 WorldTileInfoDataOffset;
        public Int32[] ChunkIDs;
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

        #region Special Variables
        public bool FileVersionUE4IsZero = false;
        #endregion

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPackageFileSummary& Sum)")]
        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Tag);
            if (Tag != ObjectVersion.PACKAGE_FILE_TAG)
            {
                throw new FormatException("File signature mismatch");
            }
            transfer.Move(ref LegacyFileVersion);
            if (LegacyFileVersion != -4)
            {
                transfer.Move(ref LegacyUE3Version);
            }

            if (FileVersionUE4IsZero)
            {
                transfer.Move(0);
            }
            else
            {
                transfer.Move(ref FileVersionUE.FileVersionUE4);
            }
            if (FileVersionUE.FileVersionUE4 == 0)
            {
                FileVersionUE4IsZero = true;
                FileVersionUE.FileVersionUE4 = (int)EUnrealEngineObjectUE4Version.VER_UE4_AUTOMATIC_VERSION;
            }
            if (LegacyFileVersion <= -8)
            {
                transfer.Move(ref FileVersionUE.FileVersionUE5);
            }
            transfer.Move(ref FileVersionLicenseeUE);
            if (LegacyFileVersion <= -2)
            {
                transfer.Move(ref CustomVersionContainer.Versions);
            }
            transfer.Move(ref TotalHeaderSize);
            transfer.Move(ref PackageName);
            transfer.MoveEnum(ref PackageFlags);
            transfer.Move(ref NameCount);
            transfer.Move(ref NameOffset);
            if (transfer.Supports.ADD_SOFTOBJECTPATH_LIST)
            {
                transfer.Move(ref SoftObjectPathsCount);
                transfer.Move(ref SoftObjectPathsOffset);
            }
            if (!transfer.GlobalObjects.IsFilterEditorOnly() && transfer.Supports.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID)
            {
                transfer.Move(ref LocalizationId);
            }
            if (transfer.Supports.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES)
            {
                transfer.Move(ref GatherableTextDataCount);
                transfer.Move(ref GatherableTextDataOffset);
            }
            transfer.Move(ref ExportCount);
            transfer.Move(ref ExportOffset);
            transfer.Move(ref ImportCount);
            transfer.Move(ref ImportOffset);
            transfer.Move(ref DependsOffset);
            if (transfer.Supports.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP)
            {
                transfer.Move(ref SoftPackageReferencesCount);
                transfer.Move(ref SoftPackageReferencesOffset);
            }
            if (transfer.Supports.VER_UE4_ADDED_SEARCHABLE_NAMES)
            {
                transfer.Move(ref SearchableNamesOffset);
            }
            transfer.Move(ref ThumbnailTableOffset);
            transfer.Move(ref Guid);
            if (!transfer.GlobalObjects.IsFilterEditorOnly() && transfer.Supports.VER_UE4_ADDED_PACKAGE_OWNER)
            {
                transfer.Move(ref PersistentGuid);
            }
            if (!transfer.GlobalObjects.IsFilterEditorOnly() && transfer.Supports.VER_UE4_ADDED_PACKAGE_OWNER && !transfer.Supports.VER_UE4_NON_OUTER_PACKAGE_IMPORT)
            {
                transfer.Move(ref OwnerPersistentGuid);
            }
            transfer.Move(ref Generations);
            if (transfer.Supports.VER_UE4_ENGINE_VERSION_OBJECT)
            {
                transfer.Move(ref SavedByEngineVersion);
            }
            else
            {
                transfer.Move(ref EngineChangelist);
            }
            if (transfer.Supports.VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION)
            {
                transfer.Move(ref CompatibleWithEngineVersion);
            }
            transfer.Move(ref CompressionFlags);
            transfer.Move(ref CompressedChunkSize);
            transfer.Move(ref PackageSource);
            transfer.Move(ref AdditionalPackagesToCook);
            if (LegacyFileVersion > -7)
            {
                transfer.Move(ref NumTextureAllocations);
            }
            transfer.Move(ref AssetRegistryDataOffset);
            transfer.Move(ref BulkDataStartOffset);
            if (transfer.Supports.VER_UE4_WORLD_LEVEL_INFO)
            {
                transfer.Move(ref WorldTileInfoDataOffset);
            }
            if (transfer.Supports.VER_UE4_CHANGED_CHUNKID_TO_BE_AN_ARRAY_OF_CHUNKIDS)
            {
                transfer.Move(ref ChunkIDs);
            }
            else if (transfer.Supports.VER_UE4_ADDED_CHUNKID_TO_ASSETDATA_AND_UPACKAGE)
            {
                transfer.Move(ref ChunkID);
            }
            if (transfer.Supports.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS)
            {
                transfer.Move(ref PreloadDependencyCount);
                transfer.Move(ref PreloadDependencyOffset);
            }
            if (transfer.Supports.NAMES_REFERENCED_FROM_EXPORT_DATA)
            {
                transfer.Move(ref NamesReferencedFromExportDataCount);
            }
            if (transfer.Supports.PAYLOAD_TOC)
            {
                transfer.Move(ref PayloadTocOffset);
            }
            if (transfer.Supports.DATA_RESOURCES)
            {
                transfer.Move(ref DataResourceOffset);
            }
            return this;
        }
    }

    #region Members
    public class FPackageFileVersion
    {
        public Int32 FileVersionUE4;
        public Int32 FileVersionUE5;
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

    [DebuggerDisplay("{Key} ({Version})")]
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

    public class FGenerationInfo : ITransferible
    {
        public Int32 ExportCount;
        public Int32 NameCount;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ExportCount);
            transfer.Move(ref NameCount);
            return this;
        }
    }

    public class FEngineVersion : ITransferible
    {
        public UInt16 Major;
        public UInt16 Minor;
        public UInt16 Patch;
        public UInt32 Changelist;
        public FString Branch;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Major);
            transfer.Move(ref Minor);
            transfer.Move(ref Patch);
            transfer.Move(ref Changelist);
            transfer.Move(ref Branch);
            return this;
        }
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
