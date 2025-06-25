
namespace AssetTool
{
    public class FLinkerTables : Transferible<FLinkerTables>
    {
        public int SizeOf() => 4 + Map.Count * FPackageIndex.SIZE + Map.Values.Count * 4 + Map.Values.Sum(x => x.Count * 8);

        public int SearchableNamesOffset;
        public Dictionary<FPackageIndex, List<FName>> Map;

        public FLinkerTables() { }

        public FLinkerTables(FPackageFileSummary PackageFileSummary)
        {
            SearchableNamesOffset = PackageFileSummary.SearchableNamesOffset;
        }

        [Location("bool FPackageReader::SerializeSearchableNamesMap(FLinkerTables& OutSearchableNames)")]
        public override ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_ADDED_SEARCHABLE_NAMES && (SearchableNamesOffset > 0 || Map is { }))
            {
                SerializeSearchableNamesMap(transfer);
            }
            return this;
        }

        [Location("void FLinkerTables::SerializeSearchableNamesMap(FStructuredArchive::FSlot Slot)")]
        private void SerializeSearchableNamesMap(Transfer transfer)
        {
            transfer.Move(ref Map);
        }
    }
}
