
namespace AssetTool
{
    public class AssetHeader
    {
        public FPackageFileSummary PackageFileSummary;
        public List<FNameEntrySerialized> NameMap;
        public List<FSoftObjectPath> SoftObjectPathList;
        public List<FGatherableTextData> GatherableTextDataList;
        public List<FObjectImport> ImportMap;
        public List<FObjectExport> ExportMap;
        public DependsMap DependsMap;

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
                return [PackageFileSummary.AssetRegistryDataOffset, ExportMap[0].SerialOffset];
        }
        #endregion
    }

    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, AssetHeader item)
        {
            var transfer = GlobalObjects.Transfer;

            writer.Write(item.PackageFileSummary);

            writer.Write(item.NameMap);

            item.SoftObjectPathList.ForEach(x => x.MoveComplete(transfer));

            item.GatherableTextDataList.ForEach(x => x.Move(transfer));

            writer.WriteValue(ref item.ImportMap, item.GetType().GetField("ImportMap")); //@@@ Remove WriteValue

            writer.Write(item.ExportMap);

            writer.WriteValue(ref item.DependsMap, item.GetType().GetField("DependsMap")); //@@@ Remove WriteValue

            if (item.BeforeSoftPackageReferenceList is { })
                writer.Write(item.BeforeSoftPackageReferenceList);

            writer.WriteList(item.SoftPackageReferenceList);

            writer.Write(item.SearchableNamesMap);

            writer.Write(item.Thumbnails);

            writer.Write(item.ObjectNameToFileOffsetMap);

            writer.Write(item.AssetRegistryData);

            writer.Write(item.Pad);
        }

        public static void Read(this BinaryReader reader, AssetHeader item)
        {
            var transfer = GlobalObjects.Transfer;
            long[] offsets;

            item.PackageFileSummary = reader.Read(item.PackageFileSummary);
            offsets = item.SummaryOffsets();
            reader.BaseStream.Position = offsets[0];
            item.PackageFileSummary.AutoCheck("PackageFileSummary", reader.BaseStream, offsets, (writer) => writer.Write(item.PackageFileSummary));
            Log.Info($"[ 0] {offsets[0],4} - {offsets[1],4} ({offsets[1] - offsets[0],4}): PackageFileSummary. Size({item.PackageFileSummary.TotalHeaderSize})");

            offsets = item.NameOffsets();
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[ 1] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): NameMap");
            item.NameMap = reader.Read(item.NameMap, item.PackageFileSummary.NameCount);
            GlobalNames.Set(item.NameMap);
            item.NameMap.AutoCheck("NameMap", reader.BaseStream, offsets, (writer) => writer.Write(item.NameMap));

            offsets = item.SoftObjectPathsOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[ 2] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): SoftObjectPathList");
            item.SoftObjectPathList = MoveSoftObjectPathList(GlobalObjects.Transfer, item);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList;
            item.SoftObjectPathList.AutoCheck("SoftObjectPathList", reader.BaseStream, offsets, (writer) => MoveSoftObjectPathList(GlobalObjects.Transfer, item));

            offsets = item.GatherableOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[ 3] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): GatherableTextDataList");
            reader.BaseStream.Position = item.PackageFileSummary.GatherableTextDataOffset;
            item.GatherableTextDataList = MoveGatherableTextDataList(GlobalObjects.Transfer, item);
            item.GatherableTextDataList.AutoCheck("GatherableTextData", reader.BaseStream, offsets, (writer) => MoveGatherableTextDataList(GlobalObjects.Transfer, item));

            offsets = item.ImportOffsets();
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[ 4] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): ImportMap");
            item.ImportMap = reader.ReadList<FObjectImport>(item.PackageFileSummary.ImportOffset, item.PackageFileSummary.ImportCount);
            item.ImportMap.AutoCheck("ImportMap", reader.BaseStream, offsets); //@@@ Remove WriteValue

            offsets = item.ExportOffsets();
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[ 5] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): ExportMap");
            item.ExportMap = reader.Read(item.ExportMap, item.PackageFileSummary.ExportCount);
            GlobalObjects.ExportMap = item.ExportMap;
            item.ExportMap.AutoCheck("ExportMap", reader.BaseStream, offsets, (writer) => writer.Write(item.ExportMap));

            offsets = item.DependsOffsets();
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[ 6] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): DependsMap");
            item.DependsMap = MoveDependsMap(transfer, item);
            item.DependsMap.AutoCheck("Depends", reader.BaseStream, offsets); //@@@ Remove WriteValue

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
                Log.Info($"[ 7] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): SoftPackageReferenceList");
                item.SoftPackageReferenceList = reader.ReadList<FName>(-1, item.PackageFileSummary.SoftPackageReferencesCount);
                item.SoftPackageReferenceList.AutoCheck("SoftPackageReferenceList", reader.BaseStream, offsets);//@@@ Remove WriteValue
            }

            offsets = item.SearchableNamesOffsets(reader, null);
            reader.BaseStream.Position = offsets[0];
            item.SearchableNamesMap = reader.Read(item.SearchableNamesMap, item.PackageFileSummary.SearchableNamesOffset);
            offsets = item.SearchableNamesOffsets(reader, item.SearchableNamesMap);
            Log.Info($"[ 8] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): SearchableNamesMap");
            item.SearchableNamesMap.AutoCheck("SearchableNames", reader.BaseStream, offsets, (writer) => writer.Write(item.SearchableNamesMap));

            offsets = item.ThumbnailsOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[ 9] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): Thumbnails");
            item.Thumbnails = reader.Read(item.Thumbnails, item.PackageFileSummary.ThumbnailTableOffset);
            item.Thumbnails.AutoCheck("Thumbnails", reader.BaseStream, offsets, (writer) => writer.Write(item.Thumbnails));

            offsets = item.ThumbnailTableOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[10] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): ObjectNameToFileOffsetMap");
            item.ObjectNameToFileOffsetMap = reader.Read(item.ObjectNameToFileOffsetMap, item.PackageFileSummary.ThumbnailTableOffset);
            item.ObjectNameToFileOffsetMap.AutoCheck("ThumbnailTable", reader.BaseStream, offsets);//@@@ Remove WriteValue

            offsets = item.AssetRegistryDataOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            Log.Info($"[11] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0]}): AssetRegistryData");
            item.AssetRegistryData = reader.Read(item.AssetRegistryData);
            item.AssetRegistryData.AutoCheck("AssetRegistryData", reader.BaseStream, offsets, (writer) => writer.Write(item.AssetRegistryData));

            reader.Read(ref item.Pad, item.PackageFileSummary.TotalHeaderSize - reader.BaseStream.Position);
        }

        private static DependsMap MoveDependsMap(Transfer transfer, AssetHeader item)
        {
            item.DependsMap ??= new();
            return item.DependsMap.Move(transfer, item.PackageFileSummary.ExportCount);
        }

        private static List<FSoftObjectPath> MoveSoftObjectPathList(Transfer transfer, AssetHeader item)
        {
            item.SoftObjectPathList = item.SoftObjectPathList.Resize(transfer, item.PackageFileSummary.SoftObjectPathsCount);
            item.SoftObjectPathList.ForEach(x => x.MoveComplete(transfer));
            return item.SoftObjectPathList;
        }

        private static List<FGatherableTextData> MoveGatherableTextDataList(Transfer transfer, AssetHeader item)
        {
            item.GatherableTextDataList = item.GatherableTextDataList.Resize(transfer, item.PackageFileSummary.GatherableTextDataCount);
            item.GatherableTextDataList.ForEach(x => x.Move(transfer));
            return item.GatherableTextDataList;
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
    }
}
