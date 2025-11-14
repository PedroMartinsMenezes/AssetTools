namespace AssetTool
{
    public class ThumbnailTable : ITransferable
    {
        public int ThumbnailTableOffset;
        public List<ThumbnailEntry> ThumbnailEntries;

        public ThumbnailTable() { }

        public ThumbnailTable(int thumbnailTableOffset)
        {
            ThumbnailTableOffset = thumbnailTableOffset;
        }

        [Location("bool LoadThumbnailsFromPackage( const FString& InPackageFileName, const TSet< FName >& InObjectFullNames, FThumbnailMap& InOutThumbnails )")]
        public ITransferable Move(Transfer transfer)
        {
            if (ThumbnailTableOffset > 0 || ThumbnailEntries is { })
            {
                transfer.Move(ref ThumbnailEntries);
            }
            return this;
        }

        public class ThumbnailEntry : ITransferable
        {
            public FString ObjectShortClassName;
            public FString ObjectPathWithoutPackageName;
            public Int32 FileOffset;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref ObjectShortClassName);
                transfer.Move(ref ObjectPathWithoutPackageName);
                transfer.Move(ref FileOffset);
                return this;
            }
        }
    }
}
