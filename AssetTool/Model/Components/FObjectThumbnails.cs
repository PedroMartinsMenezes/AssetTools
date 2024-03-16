using static AssetTool.FObjectThumbnails;

namespace AssetTool
{
    public class FObjectThumbnails
    {
        public int SizeOf() => Thumbnails.Sum(x => x.SizeOf());

        public List<FObjectThumbnail> Thumbnails = [];

        [Location("void FObjectThumbnail::Serialize(FStructuredArchive::FSlot Slot)")]
        public class FObjectThumbnail
        {
            public int SizeOf() => 12 + CompressedImageData.Length;

            public Int32 ImageWidth;

            public Int32 ImageHeight;

            [Check("CheckWidthHeight")][Sized] public byte[] CompressedImageData = [];

            [Check("CheckWidthHeight")][Sized] public byte[] ImageData = [];

            public bool CheckWidthHeight()
            {
                return ImageWidth != 0 && ImageHeight != 0;
            }
        }
    }

    public static class FObjectThumbnailsExt
    {
        public static void Write(this BinaryWriter writer, FObjectThumbnails item)
        {
            for (int i = 0; i < item.Thumbnails.Count; i++)
            {
                var thumbnail = item.Thumbnails[i];

                writer.Write(thumbnail.ImageWidth);
                writer.Write(thumbnail.ImageHeight);
                writer.Write(thumbnail.CompressedImageData.Length);

                if (thumbnail.ImageWidth != 0 && thumbnail.ImageHeight != 0)
                {
                    writer.Write(thumbnail.CompressedImageData);
                }
                ///if (Slot.GetUnderlyingArchive().IsCountingMemory())
                ///{
                ///    writer.Write(thumbnail.ImageData.Length);
                ///    writer.Write(thumbnail.ImageData);
                ///}
            }
        }

        public static FObjectThumbnails Read(this BinaryReader reader, FObjectThumbnails item, long endOffset)
        {
            item ??= new();
            while (reader.BaseStream.Position < endOffset)
            {
                var thumbnail = new FObjectThumbnail();

                thumbnail.ImageWidth = reader.ReadInt32();
                thumbnail.ImageHeight = reader.ReadInt32();
                thumbnail.CompressedImageData = new byte[reader.ReadInt32()];

                if (thumbnail.ImageWidth != 0 && thumbnail.ImageHeight != 0)
                {
                    reader.Read(thumbnail.CompressedImageData);
                }
                ///if (Slot.GetUnderlyingArchive().IsCountingMemory())
                ///{
                ///    thumbnail.ImageData = new byte[reader.ReadInt32()];
                ///    reader.Read(thumbnail.ImageData);
                ///}
                item.Thumbnails.Add(thumbnail);
            }
            return item;

        }
    }
}
