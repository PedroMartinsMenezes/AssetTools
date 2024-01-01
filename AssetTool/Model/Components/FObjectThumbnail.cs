namespace AssetTool
{
    //2624..2640 16 bytes
    public class FObjectThumbnail
    {
        public Int32 ImageWidth; //2624..2628
        public Int32 ImageHeight; //2628..2632
        public List<byte> CompressedImageData; //2632..2636
        public List<byte> ImageData; //2636..2640
    }

    public static class FObjectThumbnailExt
    {
        public static void Write(this BinaryWriter writer, FObjectThumbnail item)
        {
            writer.Write(item.ImageWidth);
            writer.Write(item.ImageHeight);
            item.CompressedImageData.ForEach(writer.Write);
            item.ImageData.ForEach(writer.Write);
        }

        public static FObjectThumbnail Read(this BinaryReader reader, FObjectThumbnail item)
        {
            reader.Read(ref item.ImageWidth);
            reader.Read(ref item.ImageHeight);
            reader.Read(item.CompressedImageData);
            reader.Read(item.ImageData);
            return item;
        }
    }
}
