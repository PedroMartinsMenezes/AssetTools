using static AssetTool.FObjectThumbnails;

namespace AssetTool
{
    public class FObjectThumbnails
    {
        public List<FObjectThumbnail> Thumbnails = [];

        [Location("void FObjectThumbnail::Serialize(FStructuredArchive::FSlot Slot)")]
        public class FObjectThumbnail
        {
            public Int32 ImageWidth;
            public Int32 ImageHeight;
            [Sized] public byte[] CompressedImageData = [];
            [Check("CheckImageSize")][Sized] public byte[] ImageData = [];

            public bool CheckImageSize()
            {
                return ImageWidth != 0 && ImageHeight != 0;
            }
        }
    }

    public static class FObjectThumbnailsExt
    {
        public static void Write(this BinaryWriter writer, FObjectThumbnails item, int count)
        {
            for (int i = 0; i < count; i++)
            {
                writer.WriteFields(item.Thumbnails[i]);
            }
        }

        public static FObjectThumbnails Read(this BinaryReader reader, FObjectThumbnails item, int count)
        {
            item ??= new();
            item.Thumbnails = [];
            for (int i = 0; i < count; i++)
            {
                item.Thumbnails.Add(reader.ReadFields(new FObjectThumbnail()));
            }
            return item;

        }
    }
}
