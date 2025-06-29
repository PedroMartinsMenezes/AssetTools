using System.ComponentModel;

namespace AssetTool
{
    public class AssetHeader : Transferible<AssetHeader>
    {
        public FPackageFileSummary PackageFileSummary;
        public NameMap NameMap;
        public SoftObjectPathList SoftObjectPathList;
        public GatherableTextDataList GatherableTextDataList;
        public ImportMap ImportMap;
        public ExportMap ExportMap;
        public DependsMap DependsMap;
        public SoftPackageReferences SoftPackageReferences;
        public FLinkerTables SearchableNames;
        public FObjectThumbnails Thumbnails;
        public ThumbnailTable ThumbnailTable;
        public AssetRegistryData AssetRegistryData;
        public PadData Pad;

        [Description("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/CoreUObject/Private/UObject/LinkerLoad.cpp")]
        [Location("FLinkerLoad::ProcessPackageSummary(TMap<TPair<FName, FPackageIndex>, FPackageIndex>* ObjectNameWithOuterToExportMap)")]
        public override ITransferible Move(Transfer transfer)
        {
            long[] offsets;

            transfer.GlobalObjects.PackageFileSummary = PackageFileSummary ??= new();
            transfer.Move(ref PackageFileSummary);
            offsets = SummaryOffsets();
            PackageFileSummary.SelfCheck("PackageFileSummary", transfer, offsets);
            LogInfo(0, offsets, $"PackageFileSummary. Size({PackageFileSummary.TotalHeaderSize})");

            offsets = NameOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(1, offsets, "NameMap");
            NameMap ??= new NameMap(PackageFileSummary);
            transfer.Move(ref NameMap);
            transfer.GlobalNames.Set(NameMap.NameEntries);
            NameMap.SelfCheck("NameMap", transfer, offsets);

            transfer.GlobalObjects.SoftObjectPathList = SoftObjectPathList ??= new(PackageFileSummary);
            offsets = SoftObjectPathsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(2, offsets, "SoftObjectPathList");
            transfer.Move(ref SoftObjectPathList);
            SoftObjectPathList.SelfCheck("SoftObjectPathList", transfer, offsets);

            offsets = GatherableOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(3, offsets, "GatherableTextDataList");
            GatherableTextDataList ??= new GatherableTextDataList(PackageFileSummary);
            transfer.Move(ref GatherableTextDataList);
            GatherableTextDataList.SelfCheck("GatherableTextData", transfer, offsets);

            offsets = ImportOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(4, offsets, "ImportMap");
            ImportMap ??= new ImportMap(PackageFileSummary);
            transfer.Move(ref ImportMap);
            ImportMap.SelfCheck("ImportMap", transfer, offsets);

            transfer.GlobalObjects.ExportMap = ExportMap ??= new(PackageFileSummary);
            offsets = ExportOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(5, offsets, "ExportMap");
            ExportMap ??= new ExportMap(PackageFileSummary);
            transfer.Move(ref ExportMap);
            ExportMap.SelfCheck("ExportMap", transfer, offsets);

            offsets = DependsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(6, offsets, "DependsMap");
            DependsMap ??= new DependsMap(PackageFileSummary);
            transfer.Move(ref DependsMap);
            DependsMap.SelfCheck("Depends", transfer, offsets);

            offsets = SoftPackageReferenceOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(7, offsets, "SoftPackageReferenceList");
            SoftPackageReferences ??= new SoftPackageReferences(PackageFileSummary);
            transfer.Move(ref SoftPackageReferences);
            SoftPackageReferences.SelfCheck("SoftPackageReferenceList", transfer, offsets);

            offsets = SearchableNamesOffsets(transfer, default);
            transfer.Position = offsets[0];
            SearchableNames ??= new FLinkerTables(PackageFileSummary);
            transfer.Move(ref SearchableNames);
            offsets = SearchableNamesOffsets(transfer, SearchableNames);
            LogInfo(8, offsets, "SearchableNamesMap");
            SearchableNames.SelfCheck("SearchableNames", transfer, offsets);

            offsets = ThumbnailsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(9, offsets, "Thumbnails");
            Thumbnails ??= new FObjectThumbnails(PackageFileSummary);
            transfer.Move(ref Thumbnails);
            Thumbnails.SelfCheck("Thumbnails", transfer, offsets);

            offsets = ThumbnailTableOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(10, offsets, "ThumbnailTable");
            ThumbnailTable ??= new ThumbnailTable(PackageFileSummary);
            transfer.Move(ref ThumbnailTable);
            ThumbnailTable.SelfCheck("ThumbnailTable", transfer, offsets);

            offsets = AssetRegistryDataOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(11, offsets, "AssetRegistryData");
            AssetRegistryData ??= new AssetRegistryData(PackageFileSummary);
            transfer.Move(ref AssetRegistryData);
            AssetRegistryData.SelfCheck("AssetRegistryData", transfer, offsets);

            ///MoveWorldTileInfo();

            SerializePreloadDependencies(transfer);

            ///SerializeDataResources(transfer);

            MovePadData(transfer);

            return this;
        }

        ///private static void MoveWorldTileInfo()
        ///{
        ///    throw new NotImplementedException();
        ///}

        [Location("FLinkerLoad::SerializePreloadDependencies()")]
        private void SerializePreloadDependencies(Transfer transfer)
        {
            if (PackageFileSummary.PreloadDependencyCount < 1 || PackageFileSummary.PreloadDependencyOffset <= 0)
                return;

            if (transfer.Position != PackageFileSummary.PreloadDependencyOffset)
                throw new InvalidOperationException("Cannot PreloadDependencies");
            else
                transfer.Position = PackageFileSummary.PreloadDependencyOffset;

            foreach (var exportObj in ExportMap.ObjectExports)
            {
                if (PackageFileSummary.PreloadDependencyOffset <= 0 || exportObj.FirstExportDependencyOffset < 0)
                    continue;

                transfer.Move(ref exportObj.SerializationBeforeSerializationDependencies, exportObj.SerializationBeforeSerializationDependenciesSize);

                transfer.Move(ref exportObj.CreateBeforeSerializationDependencies, exportObj.CreateBeforeSerializationDependenciesSize);

                transfer.Move(ref exportObj.SerializationBeforeCreateDependencies, exportObj.SerializationBeforeCreateDependenciesSize);

                transfer.Move(ref exportObj.CreateBeforeCreateDependencies, exportObj.CreateBeforeCreateDependenciesSize);
            }
        }

        ///private static void SerializeDataResources(Transfer transfer)
        ///{
        ///    throw new NotImplementedException();
        ///}

        private void MovePadData(Transfer transfer)
        {
            int size = PackageFileSummary.TotalHeaderSize - (int)transfer.Position;
            if (size > 0)
            {
                Pad ??= new PadData(size);
                Pad.Move(transfer);
            }
        }

        #region Offsets
        public long[] SummaryOffsets()
        {
            return [0, PackageFileSummary.NameOffset];
        }
        public long[] NameOffsets(Transfer transfer)
        {
            if (PackageFileSummary.NameCount == 0)
                return [transfer.Position, transfer.Position];
            else if (PackageFileSummary.SoftObjectPathsOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.SoftObjectPathsOffset];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.GatherableTextDataOffset];
            else
                return [PackageFileSummary.NameOffset, PackageFileSummary.ImportOffset];
        }
        public long[] SoftObjectPathsOffsets(Transfer transfer)
        {
            if (PackageFileSummary.SoftObjectPathsCount == 0)
                return [transfer.Position, transfer.Position];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.GatherableTextDataOffset];
            else
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.ImportOffset];
        }
        public long[] GatherableOffsets(Transfer transfer)
        {
            if (PackageFileSummary.GatherableTextDataCount == 0)
                return [transfer.Position, transfer.Position];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.GatherableTextDataOffset, PackageFileSummary.ImportOffset];
            else
                return [0, 0];
        }
        public long[] ImportOffsets(Transfer transfer)
        {
            if (PackageFileSummary.ImportCount == 0)
                return [transfer.Position, transfer.Position];
            else
                return [PackageFileSummary.ImportOffset, PackageFileSummary.ExportOffset];
        }
        public long[] ExportOffsets(Transfer transfer)
        {
            if (PackageFileSummary.ExportCount == 0)
                return [transfer.Position, transfer.Position];
            else
                return [PackageFileSummary.ExportOffset, PackageFileSummary.DependsOffset];
        }
        public long[] DependsOffsets(Transfer transfer)
        {
            if (PackageFileSummary.DependsOffset == 0)
                return [transfer.Position, transfer.Position];
            if (PackageFileSummary.SoftPackageReferencesOffset == 0)
                return [PackageFileSummary.DependsOffset, PackageFileSummary.DependsOffset];
            else
                return [PackageFileSummary.DependsOffset, PackageFileSummary.SoftPackageReferencesOffset];
        }
        public long[] SoftPackageReferenceOffsets(Transfer transfer)
        {
            if (PackageFileSummary.SoftPackageReferencesCount == 0)
                return [transfer.Position, transfer.Position];
            long offset1 = PackageFileSummary.SoftPackageReferencesOffset;
            long offset2 = offset1 + 8 * PackageFileSummary.SoftPackageReferencesCount;
            return [offset1, offset2];
        }
        public long[] SearchableNamesOffsets(Transfer transfer, FLinkerTables searchableNamesMap)
        {
            if (PackageFileSummary.SearchableNamesOffset == 0)
                return [transfer.Position, transfer.Position];
            else
                return [PackageFileSummary.SearchableNamesOffset, PackageFileSummary.SearchableNamesOffset + searchableNamesMap?.SizeOf() ?? 0];
        }
        public long[] ThumbnailsOffsets(Transfer transfer)
        {
            if (PackageFileSummary.ThumbnailTableOffset == 0)
                return [transfer.Position, transfer.Position];
            else
                return [transfer.Position, PackageFileSummary.ThumbnailTableOffset];
        }
        public long[] ThumbnailTableOffsets(Transfer transfer)
        {
            if (PackageFileSummary.ThumbnailTableOffset == 0)
                return [transfer.Position, transfer.Position];
            else
                return [PackageFileSummary.ThumbnailTableOffset, PackageFileSummary.AssetRegistryDataOffset];
        }
        public long[] AssetRegistryDataOffsets(Transfer transfer)
        {
            if (PackageFileSummary.ExportCount == 0)
                return [transfer.Position, transfer.Position];
            else if (PackageFileSummary.AssetRegistryDataOffset == 0)
                return [transfer.Position, transfer.Position];
            else if (PackageFileSummary.PreloadDependencyOffset == 0)
                return [PackageFileSummary.AssetRegistryDataOffset, ExportMap.ObjectExports[0].SerialOffset];
            else
                return [PackageFileSummary.AssetRegistryDataOffset, PackageFileSummary.PreloadDependencyOffset];
        }
        #endregion

        private static void LogInfo(int index, long[] offsets, string msg)
        {
            Log.Info($"[{index,3}] {offsets[0],7} - {offsets[1],7} ({offsets[1] - offsets[0],7}): {msg}");
        }
    }
}
