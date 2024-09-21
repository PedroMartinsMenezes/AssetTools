namespace AssetTool
{
    public class AssetHeader
    {
        public FPackageFileSummary PackageFileSummary = new();
        public NameMap NameMap = new();
        public SoftObjectPathList SoftObjectPathList = new();
        public GatherableTextDataList GatherableTextDataList = new();
        public ImportMap ImportMap = new();
        public ExportMap ExportMap = new();
        public DependsMap DependsMap = new();

        public FString BeforeSoftPackageReferenceList;

        [Location("bool FPackageReader::SerializeSoftPackageReferenceList()")]
        public List<FName> SoftPackageReferenceList;

        public SearchableNamesMap SearchableNamesMap;
        public ThumbnailTable ObjectNameToFileOffsetMap;
        public FObjectThumbnails Thumbnails;
        public AssetRegistryData AssetRegistryData;
        public PadData Pad;

        #region Offsets
        public long[] SummaryOffsets()
        {
            return [0, PackageFileSummary.NameOffset];
        }
        public long[] NameOffsets()
        {
            if (PackageFileSummary.NameCount == 0)
                return [0, 0];
            else if (PackageFileSummary.SoftObjectPathsOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.SoftObjectPathsOffset];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.GatherableTextDataOffset];
            else
                return [PackageFileSummary.NameOffset, PackageFileSummary.ImportOffset];
        }
        public long[] SoftObjectPathsOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.SoftObjectPathsCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.GatherableTextDataOffset];
            else
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.ImportOffset];
        }
        public long[] GatherableOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.GatherableTextDataCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.GatherableTextDataOffset, PackageFileSummary.ImportOffset];
            else
                return [0, 0];
        }
        public long[] ImportOffsets()
        {
            if (PackageFileSummary.ImportCount == 0)
                return [0, 0];
            else
                return [PackageFileSummary.ImportOffset, PackageFileSummary.ExportOffset];
        }
        public long[] ExportOffsets()
        {
            if (PackageFileSummary.ExportCount == 0)
                return [0, 0];
            else
                return [PackageFileSummary.ExportOffset, PackageFileSummary.DependsOffset];
        }
        public long[] DependsOffsets()
        {
            if (PackageFileSummary.SoftPackageReferencesOffset == 0)
                return [PackageFileSummary.DependsOffset, PackageFileSummary.DependsOffset];
            else
                return [PackageFileSummary.DependsOffset, PackageFileSummary.SoftPackageReferencesOffset];
        }
        public long[] SoftPackageReferenceOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.SoftPackageReferencesCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            long offset1 = PackageFileSummary.SoftPackageReferencesOffset;
            long offset2 = offset1 + 8 * PackageFileSummary.SoftPackageReferencesCount;
            return [offset1, offset2];
        }
        public long[] SearchableNamesOffsets(BinaryReader reader, SearchableNamesMap searchableNamesMap)
        {
            if (PackageFileSummary.SearchableNamesOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.SearchableNamesOffset, PackageFileSummary.SearchableNamesOffset + searchableNamesMap?.SizeOf() ?? 0];
        }
        public long[] ThumbnailsOffsets(BinaryReader reader = null)
        {
            if (reader is { } && PackageFileSummary.ThumbnailTableOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else if (reader is { } && PackageFileSummary.ThumbnailTableOffset > 0)
                return [reader.BaseStream.Position, PackageFileSummary.ThumbnailTableOffset];
            else
                return [PackageFileSummary.ThumbnailTableOffset - Thumbnails?.SizeOf() ?? 0, PackageFileSummary.ThumbnailTableOffset];
        }
        public long[] ThumbnailTableOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.ThumbnailTableOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.ThumbnailTableOffset, PackageFileSummary.AssetRegistryDataOffset];
        }
        public long[] AssetRegistryDataOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.AssetRegistryDataOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.AssetRegistryDataOffset, ExportMap.ObjectExports[0].SerialOffset];
        }
        #endregion
    }

    public static class StructHeaderExt
    {
        public static void Read(this BinaryReader reader, AssetHeader item)
        {
            var transfer = GlobalObjects.Transfer;
            long[] offsets;

            GlobalObjects.PackageFileSummary = item.PackageFileSummary;
            item.PackageFileSummary.Move(transfer);
            offsets = item.SummaryOffsets();
            reader.BaseStream.Position = offsets[0];
            item.PackageFileSummary.SelfCheck("PackageFileSummary", reader.BaseStream, offsets);
            LogInfo(0, offsets, $"PackageFileSummary. Size({item.PackageFileSummary.TotalHeaderSize})");

            offsets = item.NameOffsets();
            reader.BaseStream.Position = offsets[0];
            LogInfo(1, offsets, "NameMap");
            item.NameMap.Move(transfer, item.PackageFileSummary.NameCount);
            GlobalNames.Set(item.NameMap.NameEntries);
            item.NameMap.SelfCheck("NameMap", reader.BaseStream, offsets);

            offsets = item.SoftObjectPathsOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(2, offsets, "SoftObjectPathList");
            item.SoftObjectPathList.Move(transfer, item.PackageFileSummary.SoftObjectPathsCount);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList.SoftObjectPaths;
            item.SoftObjectPathList.SelfCheck("SoftObjectPathList", reader.BaseStream, offsets);

            offsets = item.GatherableOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(3, offsets, "GatherableTextDataList");
            reader.BaseStream.Position = item.PackageFileSummary.GatherableTextDataOffset;
            item.GatherableTextDataList.Move(transfer, item.PackageFileSummary.GatherableTextDataCount);
            item.GatherableTextDataList.SelfCheck("GatherableTextData", reader.BaseStream, offsets);

            offsets = item.ImportOffsets();
            reader.BaseStream.Position = offsets[0];
            LogInfo(4, offsets, "ImportMap");
            item.ImportMap.Move(transfer, item.PackageFileSummary.ImportCount);
            item.ImportMap.SelfCheck("ImportMap", reader.BaseStream, offsets);

            offsets = item.ExportOffsets();
            reader.BaseStream.Position = offsets[0];
            LogInfo(5, offsets, "ExportMap");
            item.ExportMap.Move(transfer, item.PackageFileSummary.ExportCount);
            GlobalObjects.ExportMap = item.ExportMap.ObjectExports;
            item.ExportMap.SelfCheck("ExportMap", reader.BaseStream, offsets);

            offsets = item.DependsOffsets();
            reader.BaseStream.Position = offsets[0];
            LogInfo(6, offsets, "DependsMap");
            item.DependsMap.Move(transfer, item.PackageFileSummary.ExportCount);
            item.DependsMap.SelfCheck("Depends", reader.BaseStream, offsets);

            long pos = reader.BaseStream.Position;
            if (IsFilledString(reader))
            {
                reader.BaseStream.Position = pos;
                item.BeforeSoftPackageReferenceList = reader.ReadFString();
                item.SoftPackageReferenceList = [];
            }
            else
            {
                reader.BaseStream.Position = pos;
                offsets = item.SoftPackageReferenceOffsets(reader);
                LogInfo(7, offsets, "SoftPackageReferenceList");
                item.SoftPackageReferenceList = reader.ReadList<FName>(-1, item.PackageFileSummary.SoftPackageReferencesCount);
                item.SoftPackageReferenceList.AutoCheck("SoftPackageReferenceList", reader.BaseStream, offsets);//@@@ Remove WriteValue
            }

            offsets = item.SearchableNamesOffsets(reader, null);
            reader.BaseStream.Position = offsets[0];
            item.SearchableNamesMap = reader.Read(item.SearchableNamesMap, item.PackageFileSummary.SearchableNamesOffset);
            offsets = item.SearchableNamesOffsets(reader, item.SearchableNamesMap);
            LogInfo(8, offsets, "SearchableNamesMap");
            item.SearchableNamesMap.AutoCheck("SearchableNames", reader.BaseStream, offsets, (writer) => writer.Write(item.SearchableNamesMap));

            offsets = item.ThumbnailsOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(9, offsets, "Thumbnails");
            item.Thumbnails = reader.Read(item.Thumbnails, item.PackageFileSummary.ThumbnailTableOffset);
            item.Thumbnails.AutoCheck("Thumbnails", reader.BaseStream, offsets, (writer) => writer.Write(item.Thumbnails));

            offsets = item.ThumbnailTableOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(10, offsets, "ObjectNameToFileOffsetMap");
            item.ObjectNameToFileOffsetMap = reader.Read(item.ObjectNameToFileOffsetMap, item.PackageFileSummary.ThumbnailTableOffset);
            item.ObjectNameToFileOffsetMap.AutoCheck("ThumbnailTable", reader.BaseStream, offsets);//@@@ Remove WriteValue

            offsets = item.AssetRegistryDataOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(11, offsets, "AssetRegistryData");
            item.AssetRegistryData = reader.Read(item.AssetRegistryData);
            item.AssetRegistryData.AutoCheck("AssetRegistryData", reader.BaseStream, offsets, (writer) => writer.Write(item.AssetRegistryData));

            reader.Read(ref item.Pad, item.PackageFileSummary.TotalHeaderSize - reader.BaseStream.Position);
        }

        public static void Write(this BinaryWriter writer, AssetHeader item)
        {
            var transfer = GlobalObjects.Transfer;

            item.PackageFileSummary.Move(transfer);

            item.NameMap.Move(transfer);

            item.SoftObjectPathList.Move(transfer);

            item.GatherableTextDataList.Move(transfer);

            item.ImportMap.Move(transfer);

            item.ExportMap.Move(transfer);

            item.DependsMap.Move(transfer);

            if (item.BeforeSoftPackageReferenceList is { })
                writer.Write(item.BeforeSoftPackageReferenceList);

            writer.WriteList(item.SoftPackageReferenceList);

            writer.Write(item.SearchableNamesMap);

            writer.Write(item.Thumbnails);

            writer.Write(item.ObjectNameToFileOffsetMap);

            writer.Write(item.AssetRegistryData);

            writer.Write(item.Pad);
        }

        private static bool IsFilledString(BinaryReader reader)
        {
            try
            {
                int size = reader.ReadInt32();
                if (size == 0 || size == 1)
                {
                    return false;
                }
                byte[] nonZeroChars = new byte[size - 1];
                reader.Read(nonZeroChars);
                if (Array.Exists(nonZeroChars, (x) => x == 0))
                {
                    return false;
                }
                byte zeroChar = reader.ReadByte();
                if (zeroChar != 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void LogInfo(int index, long[] offsets, string msg)
        {
            Log.Info($"[{index}] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0],4}): {msg}");
        }
    }
}
