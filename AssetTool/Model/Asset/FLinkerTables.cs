
namespace AssetTool
{
    public class FLinkerTables : Transferible<FLinkerTables>
    {
        public int SizeOf() => 4 + Map.Count * FPackageIndex.SIZE + Map.Values.Count * 4 + Map.Values.Sum(x => x.Count * 8);

        private readonly FPackageFileSummary PackageFileSummary;

        public Dictionary<FPackageIndex, List<FName>> Map;

        public FLinkerTables()
        {
            PackageFileSummary = new();
        }

        public FLinkerTables(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        [Location("bool FPackageReader::SerializeSearchableNamesMap(FLinkerTables& OutSearchableNames)")]
        public override ITransferible Move(Transfer transfer)
        {
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_SEARCHABLE_NAMES) && (PackageFileSummary.SearchableNamesOffset > 0 || Map is { }))
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
