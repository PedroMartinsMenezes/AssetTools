namespace AssetTool
{
    public class FObjectThumbnails : ITransferable
    {
        public int ThumbnailTableOffset;
        public List<FObjectThumbnail> Thumbnails;

        public FObjectThumbnails() { }

        public FObjectThumbnails(int thumbnailTableOffset)
        {
            ThumbnailTableOffset = thumbnailTableOffset;
        }

        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveWhile(ref Thumbnails, () => transfer.Position < ThumbnailTableOffset, (x) => x.Move(transfer));
            return this;
        }

        public class FObjectThumbnail : ITransferable
        {
            public Int32 ImageWidth;
            public Int32 ImageHeight;
            public Int32 CompressedSize;
            public byte[] CompressedImageData;

            [Location("void FObjectThumbnail::Serialize(FStructuredArchive::FSlot Slot)")]
            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref ImageWidth);
                transfer.Move(ref ImageHeight);
                transfer.Move(ref CompressedSize);
                if (ImageWidth != 0 && ImageHeight != 0)
                {
                    transfer.Move(ref CompressedImageData, CompressedSize);
                }
                return this;
            }
        }
    }
}
