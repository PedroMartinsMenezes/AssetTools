using System.ComponentModel;

namespace AssetTool
{
    public class AssetHeader : ITransferible
    {
        public FPackageFileSummary PackageFileSummary;
        public NameMap NameMap;
        public SoftObjectPathList SoftObjectPathList;
        public GatherableTextDataList GatherableTextDataList;
        public MetaDataMap MetaDataMap;
        public ImportMap ImportMap;
        public ExportMap ExportMap;
        public DependsMap DependsMap;
        public SoftPackageReferences SoftPackageReferences;
        public FLinkerTables SearchableNames;
        public FObjectThumbnails Thumbnails;
        public ThumbnailTable ThumbnailTable;
        public AssetRegistryData AssetRegistryData;
        public WorkaroundPad WorkaroundPad;
        ///public FObjectDataResource ObjectDataResource;


        [Description("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/CoreUObject/Private/UObject/LinkerLoad.cpp")]
        [Location("FLinkerLoad::ProcessPackageSummary(TMap<TPair<FName, FPackageIndex>, FPackageIndex>* ObjectNameWithOuterToExportMap)")]
        public ITransferible Move(Transfer transfer)
        {
            long[] offsets;

            transfer.GlobalObjects.PackageFileSummary = PackageFileSummary ??= new();
            transfer.Move(ref PackageFileSummary);
            offsets = SummaryOffsets();
            PackageFileSummary.AutoCheck(transfer, "PackageFileSummary", transfer.Stream, offsets);
            LogInfo(0, offsets, $"PackageFileSummary. Size({PackageFileSummary.TotalHeaderSize})");

            offsets = NameOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(1, offsets, "NameMap");
            NameMap ??= new NameMap(PackageFileSummary.NameCount);
            transfer.Move(ref NameMap);
            transfer.GlobalNames.Set(NameMap.NameEntries);
            NameMap.AutoCheck(transfer, "NameMap", transfer.Stream, offsets);

            transfer.GlobalObjects.SoftObjectPathList = SoftObjectPathList ??= new(PackageFileSummary.SoftObjectPathsCount);
            offsets = SoftObjectPathsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(2, offsets, "SoftObjectPathList");
            transfer.Move(ref SoftObjectPathList);
            SoftObjectPathList.AutoCheck(transfer, "SoftObjectPathList", transfer.Stream, offsets);

            offsets = GatherableOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(3, offsets, "GatherableTextDataList");
            GatherableTextDataList ??= new GatherableTextDataList(PackageFileSummary.GatherableTextDataCount);
            transfer.Move(ref GatherableTextDataList);
            GatherableTextDataList.AutoCheck(transfer, "GatherableTextDataList", transfer.Stream, offsets);

            offsets = MetaDataOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(4, offsets, "MetaDataMap");
            MetaDataMap ??= new MetaDataMap(offsets[1] - offsets[0]);
            transfer.Move(ref MetaDataMap);
            MetaDataMap.AutoCheck(transfer, "MetaDataMap", transfer.Stream, offsets);

            transfer.GlobalObjects.ImportMap = ImportMap ??= new(PackageFileSummary.ImportCount);
            offsets = ImportOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(4, offsets, "ImportMap");
            ImportMap ??= new ImportMap(PackageFileSummary.ImportCount);
            transfer.Move(ref ImportMap);
            ImportMap.AutoCheck(transfer, "ImportMap", transfer.Stream, offsets);

            transfer.GlobalObjects.ExportMap = ExportMap ??= new(PackageFileSummary.ExportCount);
            offsets = ExportOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(5, offsets, "ExportMap");
            transfer.Move(ref ExportMap);
            ExportMap.AutoCheck(transfer, "ExportMap", transfer.Stream, offsets);

            offsets = DependsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(6, offsets, "DependsMap");
            DependsMap ??= new DependsMap(PackageFileSummary.ExportCount);
            transfer.Move(ref DependsMap);
            DependsMap.AutoCheck(transfer, "Depends", transfer.Stream, offsets);

            offsets = SoftPackageReferenceOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(7, offsets, "SoftPackageReferenceList");
            SoftPackageReferences ??= new SoftPackageReferences(PackageFileSummary.SoftPackageReferencesCount);
            transfer.Move(ref SoftPackageReferences);
            offsets[1] = offsets[1] == -1 ? transfer.Position : offsets[1];
            SoftPackageReferences.AutoCheck(transfer, "SoftPackageReferenceList", transfer.Stream, offsets);

            offsets = SearchableNamesOffsets(transfer, default);
            transfer.Position = offsets[0];
            SearchableNames ??= new FLinkerTables(PackageFileSummary.SearchableNamesOffset);
            transfer.Move(ref SearchableNames);
            offsets = SearchableNamesOffsets(transfer, SearchableNames);
            LogInfo(8, offsets, "SearchableNamesMap");
            SearchableNames.AutoCheck(transfer, "SearchableNames", transfer.Stream, offsets);

            offsets = ThumbnailsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(9, offsets, "Thumbnails");
            Thumbnails ??= new FObjectThumbnails(PackageFileSummary.ThumbnailTableOffset);
            transfer.Move(ref Thumbnails);
            Thumbnails.AutoCheck(transfer, "Thumbnails", transfer.Stream, offsets);

            offsets = ThumbnailTableOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(10, offsets, "ThumbnailTable");
            ThumbnailTable ??= new ThumbnailTable(PackageFileSummary.ThumbnailTableOffset);
            transfer.Move(ref ThumbnailTable);
            ThumbnailTable.AutoCheck(transfer, "ThumbnailTable", transfer.Stream, offsets);

            offsets = AssetRegistryDataOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(11, offsets, "AssetRegistryData");
            AssetRegistryData ??= new AssetRegistryData(PackageFileSummary.ExportCount);
            transfer.Move(ref AssetRegistryData);
            AssetRegistryData.AutoCheck(transfer, "AssetRegistryData", transfer.Stream, offsets);

            ///MoveWorldTileInfo();

            SerializePreloadDependencies(transfer);

            ///SerializeDataResourceMap(transfer);

            MovePadData(transfer);

            return this;
        }

        ///private static void MoveWorldTileInfo()
        ///{
        ///    throw new NotImplementedException();
        ///}

        [Location("FLinkerLoad::SerializePreloadDependencies()")]
        [Description("Status = SerializePreloadDependencies();")]
        private void SerializePreloadDependencies(Transfer transfer)
        {
            if (PackageFileSummary.PreloadDependencyCount < 1 || PackageFileSummary.PreloadDependencyOffset <= 0)
                return;

            if (transfer.Position != PackageFileSummary.PreloadDependencyOffset)
                throw new InvalidOperationException("Cannot PreloadDependencies");

            if (PackageFileSummary.PreloadDependencyOffset > 0)
                FObjectExport.SerializePreloadDependencies(transfer, ExportMap.ObjectExports);
        }

        ///[Location("FLinkerLoad::ELinkerStatus FLinkerLoad::SerializeDataResourceMap()")]
        ///[Description("Status = SerializeDataResourceMap();")]
        ///private void SerializeDataResourceMap(Transfer transfer)
        ///{
        ///    transfer.Move(ref ObjectDataResource);
        ///}

        [Obsolete("Fix this workaround")]
        private void MovePadData(Transfer transfer)
        {
            int size = PackageFileSummary.TotalHeaderSize - (int)transfer.Position;
            if (size > 0)
            {
                Log.Info($"Pad Data: {size} bytes at {transfer.Position}");
                WorkaroundPad ??= new();
                WorkaroundPad.Move(transfer, size);
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
            else if (PackageFileSummary.MetaDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.MetaDataOffset];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.GatherableTextDataOffset];
            else
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.ImportOffset];
        }
        public long[] GatherableOffsets(Transfer transfer)
        {
            if (PackageFileSummary.GatherableTextDataCount == 0)
                return [transfer.Position, transfer.Position];
            else if (PackageFileSummary.GatherableTextDataOffset > 0 && PackageFileSummary.MetaDataOffset > 0)
                return [PackageFileSummary.GatherableTextDataOffset, PackageFileSummary.MetaDataOffset];
            else if (PackageFileSummary.GatherableTextDataOffset > 0 && PackageFileSummary.ImportOffset > 0)
                return [PackageFileSummary.GatherableTextDataOffset, PackageFileSummary.ImportOffset];
            else
                return [0, 0];
        }
        public long[] MetaDataOffsets(Transfer transfer)
        {
            if (PackageFileSummary.MetaDataOffset == 0)
                return [transfer.Position, transfer.Position];
            else if (PackageFileSummary.ImportOffset > 0)
                return [PackageFileSummary.MetaDataOffset, PackageFileSummary.ImportOffset];
            else if (PackageFileSummary.ExportOffset > 0)
                return [PackageFileSummary.MetaDataOffset, PackageFileSummary.ExportOffset];
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
            else if (PackageFileSummary.SearchableNamesOffset != 0)
                return [PackageFileSummary.SoftPackageReferencesOffset, PackageFileSummary.SearchableNamesOffset];
            else
                return [PackageFileSummary.SoftPackageReferencesOffset, -1];
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
