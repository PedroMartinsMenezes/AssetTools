using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FPackageFileSummary : ITransferable
    {
        #region Members
        public UInt32 Tag;
        public Int32 LegacyFileVersion;
        public Int32 LegacyUE3Version;
        public FPackageFileVersion FileVersionUE;
        public Int32 FileVersionLicenseeUE;
        public FCustomVersionContainer CustomVersionContainer;
        public Int32 TotalHeaderSize;
        public FString PackageName;
        public EPackageFlags PackageFlags;
        public Int32 NameCount;
        public Int32 NameOffset;
        public Int32 SoftObjectPathsCount;
        public Int32 SoftObjectPathsOffset;
        public FString LocalizationId;
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

        public Int32 ImportTypeHierarchiesCount;
        public Int32 ImportTypeHierarchiesOffset;

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
        public FIoHash SavedHash;
        public int32 CellExportCount;
        public int32 CellExportOffset;
        public int32 CellImportCount;
        public int32 CellImportOffset;
        public int32 MetaDataOffset;
        #endregion

        #region Local Variables
        public Int32 EngineChangelist;
        public Int32 ChunkID;
        #endregion

        #region Special Variables
        public bool FileVersionUE4IsZero = false;
        #endregion

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FPackageFileSummary& Sum)")]
        public ITransferable Move(Transfer transfer)
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
                transfer.MoveConst(0);
            }
            else
            {
                transfer.MoveEnum(ref FileVersionUE.FileVersionUE4);
            }
            if (FileVersionUE.FileVersionUE4 == 0)
            {
                FileVersionUE4IsZero = true;
                FileVersionUE.FileVersionUE4 = EUnrealEngineObjectUE4Version.VER_UE4_AUTOMATIC_VERSION;
            }
            if (LegacyFileVersion <= -8)
            {
                transfer.MoveEnum(ref FileVersionUE.FileVersionUE5);
            }
            transfer.Move(ref FileVersionLicenseeUE);

            if (FileVersionUE.FileVersionUE4 < EUnrealEngineObjectUE4Version.VER_UE4_OLDEST_LOADABLE_PACKAGE)
            {
                string name = transfer.GlobalObjects.FileName;
                int min = (int)EUnrealEngineObjectUE4Version.VER_UE4_OLDEST_LOADABLE_PACKAGE;
                int ver = (int)FileVersionUE.FileVersionUE4;
                throw new InvalidOperationException($"Package is unloadable: {name}. Reason: Version is too old. Min Version: {min}, Package Version: {ver}.");
            }

            if (transfer.Supports.PACKAGE_SAVED_HASH)
            {
                transfer.Move(ref SavedHash);
                transfer.Move(ref TotalHeaderSize);
            }
            if (LegacyFileVersion <= -2)
            {
                transfer.Move(ref CustomVersionContainer, GetCustomVersionFormatForArchive(LegacyFileVersion));
            }
            if (!transfer.Supports.PACKAGE_SAVED_HASH)
            {
                transfer.Move(ref TotalHeaderSize);
            }
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
            if (transfer.Supports.VERSE_CELLS)
            {
                transfer.Move(ref CellExportCount);
                transfer.Move(ref CellExportOffset);
                transfer.Move(ref CellImportCount);
                transfer.Move(ref CellImportOffset);
            }
            if (transfer.Supports.METADATA_SERIALIZATION_OFFSET)
            {
                transfer.Move(ref MetaDataOffset);
            }
            transfer.Move(ref DependsOffset);
            if (DependsOffset < transfer.Position)
            {
                throw new InvalidOperationException($"Invalid DependsOffset: {DependsOffset}");
            }
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

            if (!transfer.Supports.PACKAGE_SAVED_HASH)
            {
                transfer.Move(ref Guid);
            }

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

        public ITransferable WriteCooked(Transfer transfer)
        {
            bool IsCooking = true;

            transfer.Move(ref Tag);//4

            transfer.Move(ref LegacyFileVersion);//8

            #region If Writing
            int32 Zero = 0;
            transfer.Move(ref Zero); //12 LegacyUE3Version
            transfer.Move(ref Zero); //16 FileVersionUE.FileVersionUE4
            transfer.Move(ref Zero); //20 FileVersionUE.FileVersionUE5
            transfer.Move(ref Zero); //24 FileVersionLicenseeUE

            if (transfer.Supports.PACKAGE_SAVED_HASH)
            {
                transfer.Move(ref SavedHash); //44
                transfer.Move(ref TotalHeaderSize); //48
            }

            FCustomVersionContainer NoCustomVersions = new();
            transfer.Move(ref NoCustomVersions, ECustomVersionSerializationFormat.Latest); //52
            #endregion

            if (!transfer.Supports.PACKAGE_SAVED_HASH)
            {
                transfer.Move(ref TotalHeaderSize); //ignored
            }
            transfer.Move(ref PackageName); //129

            if (IsCooking)
            {
                PackageFlags |= EPackageFlags.PKG_Cooked;
            }
            transfer.MoveEnum(ref PackageFlags); //133

            transfer.Move(ref NameCount); //137
            transfer.Move(ref NameOffset); //141

            if (transfer.Supports.ADD_SOFTOBJECTPATH_LIST)
            {
                transfer.Move(ref SoftObjectPathsCount); //145
                transfer.Move(ref SoftObjectPathsOffset); //149
            }

            if (!transfer.GlobalObjects.IsFilterEditorOnly() && transfer.Supports.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID)
            {
                transfer.Move(ref LocalizationId); //ignored
            }

            if (transfer.Supports.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES)
            {
                transfer.Move(ref GatherableTextDataCount); //153
                transfer.Move(ref GatherableTextDataOffset); //157
            }

            transfer.Move(ref ExportCount); //161
            transfer.Move(ref ExportOffset); //165
            transfer.Move(ref ImportCount); //169
            transfer.Move(ref ImportOffset); //173

            if (transfer.Supports.VERSE_CELLS)
            {
                transfer.Move(ref CellExportCount); //177
                transfer.Move(ref CellExportOffset); //181
                transfer.Move(ref CellImportCount); //185
                transfer.Move(ref CellImportOffset); //189
            }

            if (transfer.Supports.METADATA_SERIALIZATION_OFFSET)
            {
                transfer.Move(ref MetaDataOffset); //193
            }

            transfer.Move(ref DependsOffset); //197

            if (transfer.Supports.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP)
            {
                transfer.Move(ref SoftPackageReferencesCount); //201
                transfer.Move(ref SoftPackageReferencesOffset); //205
            }

            if (transfer.Supports.VER_UE4_ADDED_SEARCHABLE_NAMES)
            {
                transfer.Move(ref SearchableNamesOffset); //209
            }

            transfer.Move(ref ThumbnailTableOffset); //213

            if (transfer.Supports.IMPORT_TYPE_HIERARCHIES)
            {
                transfer.Move(ref ImportTypeHierarchiesCount); //217
                transfer.Move(ref ImportTypeHierarchiesOffset); //221
            }

            //Linha 337
            //if (Sum.GetFileVersionUE() < EUnrealEngineObjectUE5Version::PACKAGE_SAVED_HASH)

            //transfer.Move(ref Generations); //233

            //FEngineVersion EmptyEngineVersion; //onde era SavedByEngineVersion
            //transfer.Move(ref EmptyEngineVersion); //247

            //FEngineVersion EmptyEngineVersion; //onde era CompatibleWithEngineVersion
            //transfer.Move(ref EmptyEngineVersion); //261

            //transfer.Move(ref CompressionFlags); //265

            return this; //321
        }

        private static ECustomVersionSerializationFormat GetCustomVersionFormatForArchive(int32 LegacyFileVersion)
        {
            ECustomVersionSerializationFormat CustomVersionFormat = ECustomVersionSerializationFormat.Unknown;
            if (LegacyFileVersion == -2)
            {
                CustomVersionFormat = ECustomVersionSerializationFormat.Enums;
            }
            else if (LegacyFileVersion < -2 && LegacyFileVersion >= -5)
            {
                CustomVersionFormat = ECustomVersionSerializationFormat.Guids;
            }
            else if (LegacyFileVersion < -5)
            {
                CustomVersionFormat = ECustomVersionSerializationFormat.Optimized;
            }
            return CustomVersionFormat;
        }
    }

    #region Members
    public struct FPackageFileVersion
    {
        public EUnrealEngineObjectUE4Version FileVersionUE4;
        public EUnrealEngineObjectUE5Version FileVersionUE5;
    }

    public class FCustomVersionContainer : ITransferable<ECustomVersionSerializationFormat>
    {
        public List<FEnumCustomVersion_DEPRECATED> OldTags;
        public List<FGuidCustomVersion_DEPRECATED> VersionArray;
        public List<FCustomVersion> Versions;

        public ITransferable Move(Transfer transfer, ECustomVersionSerializationFormat format)
        {
            switch (format)
            {
                case ECustomVersionSerializationFormat.Enums:
                    transfer.Move(ref OldTags);
                    Versions ??= [];
                    break;
                case ECustomVersionSerializationFormat.Guids:
                    transfer.Move(ref VersionArray);
                    //Updating the Versions member
                    Versions ??= VersionArray.Select(x => new FCustomVersion { Key = x.Key, Version = x.Version }).ToList();
                    break;
                case ECustomVersionSerializationFormat.Optimized:
                    transfer.Move(ref Versions);
                    break;
            }
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    [DebuggerDisplay("{Key} ({Version})")]
    public class FCustomVersion : ITransferable
    {
        public FGuid Key;
        public Int32 Version;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Key);
            transfer.Move(ref Version);
            return this;
        }
    }

    public class FGenerationInfo : ITransferable
    {
        public Int32 ExportCount;
        public Int32 NameCount;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ExportCount);
            transfer.Move(ref NameCount);
            return this;
        }
    }

    public class FEngineVersion : ITransferable
    {
        public UInt16 Major;
        public UInt16 Minor;
        public UInt16 Patch;
        public UInt32 Changelist;
        public FString Branch;

        public ITransferable Move(Transfer transfer)
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
