namespace AssetTool
{
    public class ThumbnailTable : ITransferible
    {
        public int ThumbnailTableOffset;
        public List<ThumbnailEntry> ThumbnailEntries;

        public ThumbnailTable() { }

        public ThumbnailTable(int thumbnailTableOffset)
        {
            ThumbnailTableOffset = thumbnailTableOffset;
        }

        [Location("bool LoadThumbnailsFromPackage( const FString& InPackageFileName, const TSet< FName >& InObjectFullNames, FThumbnailMap& InOutThumbnails )")]
        public ITransferible Move(Transfer transfer)
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
