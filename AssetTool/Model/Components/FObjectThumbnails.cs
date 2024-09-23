namespace AssetTool
{
    public class FObjectThumbnails : ITransferible<FObjectThumbnails>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<FObjectThumbnail> Thumbnails = [];

        public FObjectThumbnails()
        {
            PackageFileSummary = new();
        }

        public FObjectThumbnails(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        public override void Move(Transfer transfer)
        {
            Thumbnails.MoveWhile(transfer, () => transfer.Position < PackageFileSummary.ThumbnailTableOffset, (x) => x.Move(transfer));
        }

        [Location("void FObjectThumbnail::Serialize(FStructuredArchive::FSlot Slot)")]
        public class FObjectThumbnail
        {
            public Int32 ImageWidth;
            public Int32 ImageHeight;
            public Int32 CompressedSize;
            public byte[] CompressedImageData = [];
            public byte[] ImageData = [];

            public void Move(Transfer transfer)
            {
                transfer.Move(ref ImageWidth);
                transfer.Move(ref ImageHeight);
                transfer.Move(ref CompressedSize);
                if (ImageWidth != 0 && ImageHeight != 0)
                {
                    transfer.Move(ref CompressedImageData, CompressedSize);
                }
            }
        }
    }
}
