using System.ComponentModel;

namespace AssetTool
{
    [Description("void FObjectThumbnail::Serialize(FStructuredArchive::FSlot Slot)")]
    public class FObjectThumbnail
    {
        public Int32 ImageWidth;
        public Int32 ImageHeight;
        [Sized] public List<byte> CompressedImageData;
        [Sized] public List<byte> ImageData;
    }
}
