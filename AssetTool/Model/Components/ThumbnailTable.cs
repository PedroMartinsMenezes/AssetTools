namespace AssetTool
{
    public class ThumbnailTable : ITransferible<ThumbnailTable>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<ThumbnailEntry> ThumbnailEntries;

        public ThumbnailTable()
        {
            PackageFileSummary = new();
        }

        public ThumbnailTable(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        [Location("bool LoadThumbnailsFromPackageInternal( const FString& InPackageFileName, const TSet< FName >& InObjectFullNames, FThumbnailMap& InOutThumbnails )")]
        public override void Move(Transfer transfer)
        {
            if (PackageFileSummary.ThumbnailTableOffset > 0 || ThumbnailEntries is { })
            {
                ThumbnailEntries ??= new();
                ThumbnailEntries.Resize(transfer);
                ThumbnailEntries.ForEach(x => x.Move(transfer));
            }
        }

        public class ThumbnailEntry
        {
            public FString ObjectShortClassName = new();
            public FString ObjectPathWithoutPackageName = new();
            public Int32 FileOffset;

            public void Move(Transfer transfer)
            {
                transfer.Move(ref ObjectShortClassName);
                transfer.Move(ref ObjectPathWithoutPackageName);
                transfer.Move(ref FileOffset);
            }
        }
    }
}
