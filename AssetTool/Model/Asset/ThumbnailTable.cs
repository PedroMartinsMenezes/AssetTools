namespace AssetTool
{
    public class ThumbnailTable : Transferible<ThumbnailTable>
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
        public override ITransferible Move(Transfer transfer)
        {
            if (PackageFileSummary.ThumbnailTableOffset > 0 || ThumbnailEntries is { })
            {
                transfer.Move(ref ThumbnailEntries);
            }
            return this;
        }

        public class ThumbnailEntry : ITransferible
        {
            public FString ObjectShortClassName;
            public FString ObjectPathWithoutPackageName;
            public Int32 FileOffset;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref ObjectShortClassName);
                transfer.Move(ref ObjectPathWithoutPackageName);
                transfer.Move(ref FileOffset);
                return this;
            }
        }
    }
}
