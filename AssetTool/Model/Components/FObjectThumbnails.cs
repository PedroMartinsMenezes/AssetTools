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
            [Check("CheckImageData")][Sized] public byte[] ImageData = [];

            public bool CheckImageData()
            {
                return CompressedImageData.Length == 0 && ImageWidth != 0 && ImageHeight != 0;
            }
        }
    }

    public static class FObjectThumbnailsExt
    {
        public static void Write(this BinaryWriter writer, FObjectThumbnails item)
        {
            for (int i = 0; i < item.Thumbnails.Count; i++)
            {
                writer.WriteFields(item.Thumbnails[i]);
            }
        }

        public static FObjectThumbnails Read(this BinaryReader reader, FObjectThumbnails item, long endOffset)
        {
            item ??= new();
            item.Thumbnails = [];
            while (reader.BaseStream.Position < endOffset)
            {
                item.Thumbnails.Add(reader.ReadFields(new FObjectThumbnail()));
            }
            return item;

        }
    }
}
