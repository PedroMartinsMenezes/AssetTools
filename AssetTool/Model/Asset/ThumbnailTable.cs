namespace AssetTool
{
    public class ThumbnailTable : Transferible<ThumbnailTable>
    {
        public int ThumbnailTableOffset;
        public List<ThumbnailEntry> ThumbnailEntries;

        public ThumbnailTable() { }

        public ThumbnailTable(int thumbnailTableOffset)
        {
            ThumbnailTableOffset = thumbnailTableOffset;
        }

        [Location("bool LoadThumbnailsFromPackageInternal( const FString& InPackageFileName, const TSet< FName >& InObjectFullNames, FThumbnailMap& InOutThumbnails )")]
        public override ITransferible Move(Transfer transfer)
        {
            if (ThumbnailTableOffset > 0 || ThumbnailEntries is { })
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
