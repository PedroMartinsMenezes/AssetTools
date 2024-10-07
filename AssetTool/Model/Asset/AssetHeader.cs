namespace AssetTool
{
    public class AssetHeader : Transferible<AssetHeader>
    {
        public FPackageFileSummary PackageFileSummary = new();
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

        [Location("class FPackageReader : public FArchiveUObject")]
        public override ITransferible Move(Transfer transfer)
        {
            long[] offsets;

            GlobalObjects.PackageFileSummary = PackageFileSummary;
            offsets = SummaryOffsets();
            PackageFileSummary.Move(transfer);
            PackageFileSummary.SelfCheck("PackageFileSummary", transfer, offsets);
            LogInfo(0, offsets, $"PackageFileSummary. Size({PackageFileSummary.TotalHeaderSize})");

            offsets = NameOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(1, offsets, "NameMap");
            NameMap ??= new NameMap(PackageFileSummary);
            NameMap.Move(transfer);
            GlobalNames.Set(transfer, NameMap.NameEntries);
            NameMap.SelfCheck("NameMap", transfer, offsets);

            offsets = SoftObjectPathsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(2, offsets, "SoftObjectPathList");
            SoftObjectPathList ??= new SoftObjectPathList(PackageFileSummary);
            SoftObjectPathList.Move(transfer);
            GlobalObjects.SoftObjectPathList = SoftObjectPathList.SoftObjectPaths;
            SoftObjectPathList.SelfCheck("SoftObjectPathList", transfer, offsets);

            offsets = GatherableOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(3, offsets, "GatherableTextDataList");
            GatherableTextDataList ??= new GatherableTextDataList(PackageFileSummary);
            GatherableTextDataList.Move(transfer);
            GatherableTextDataList.SelfCheck("GatherableTextData", transfer, offsets);

            offsets = ImportOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(4, offsets, "ImportMap");
            ImportMap ??= new ImportMap(PackageFileSummary);
            ImportMap.Move(transfer);
            ImportMap.SelfCheck("ImportMap", transfer, offsets);

            offsets = ExportOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(5, offsets, "ExportMap");
            ExportMap ??= new ExportMap(PackageFileSummary);
            ExportMap.Move(transfer);
            GlobalObjects.ExportMap = ExportMap.ObjectExports;
            ExportMap.SelfCheck("ExportMap", transfer, offsets);

            offsets = DependsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(6, offsets, "DependsMap");
            DependsMap ??= new DependsMap(PackageFileSummary);
            DependsMap.Move(transfer);
            DependsMap.SelfCheck("Depends", transfer, offsets);

            offsets = SoftPackageReferenceOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(7, offsets, "SoftPackageReferenceList");
            SoftPackageReferences ??= new SoftPackageReferences(PackageFileSummary);
            SoftPackageReferences.Move(transfer);
            SoftPackageReferences.SelfCheck("SoftPackageReferenceList", transfer, offsets);

            offsets = SearchableNamesOffsets(transfer, null);
            transfer.Position = offsets[0];
            SearchableNames ??= new FLinkerTables(PackageFileSummary);
            SearchableNames.Move(transfer);
            offsets = SearchableNamesOffsets(transfer, SearchableNames);
            LogInfo(8, offsets, "SearchableNamesMap");
            SearchableNames.SelfCheck("SearchableNames", transfer, offsets);

            offsets = ThumbnailsOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(9, offsets, "Thumbnails");
            Thumbnails ??= new FObjectThumbnails(PackageFileSummary);
            Thumbnails.Move(transfer);
            Thumbnails.SelfCheck("Thumbnails", transfer, offsets);

            offsets = ThumbnailTableOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(10, offsets, "ThumbnailTable");
            ThumbnailTable ??= new ThumbnailTable(PackageFileSummary);
            ThumbnailTable.Move(transfer);
            ThumbnailTable.SelfCheck("ThumbnailTable", transfer, offsets);

            offsets = AssetRegistryDataOffsets(transfer);
            transfer.Position = offsets[0];
            LogInfo(11, offsets, "AssetRegistryData");
            AssetRegistryData ??= new AssetRegistryData();
            AssetRegistryData.Move(transfer);
            AssetRegistryData.SelfCheck("AssetRegistryData", transfer, offsets);

            int size = PackageFileSummary.TotalHeaderSize - (int)transfer.Position;
            if (size > 0)
                Pad.Move(transfer, size);
            return this;
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
            if (PackageFileSummary.AssetRegistryDataOffset == 0)
                return [transfer.Position, transfer.Position];
            else
                return [PackageFileSummary.AssetRegistryDataOffset, ExportMap.ObjectExports[0].SerialOffset];
        }
        #endregion

        private static void LogInfo(int index, long[] offsets, string msg)
        {
            Log.Info($"[{index,3}] {offsets[0],7} - {offsets[1],7} ({offsets[1] - offsets[0],7}): {msg}");
        }
    }
}
