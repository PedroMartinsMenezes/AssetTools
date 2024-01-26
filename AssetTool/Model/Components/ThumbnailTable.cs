using System.ComponentModel;
using System.Reflection.PortableExecutable;
using static AssetTool.ThumbnailTable;

namespace AssetTool
{

    [Description("Load the thumbnail table of contents")]
    public class ThumbnailTable
    {
        [Sized]
        public List<ThumbnailEntry> ThumbnailEntries = [];

        public List<FObjectThumbnail> Thumbnails = [];

        public class ThumbnailEntry
        {
            public FString ObjectShortClassName = new();
            public FString ObjectPathWithoutPackageName = new();
            public Int32 FileOffset;
        }

        [Description("void FObjectThumbnail::Serialize(FStructuredArchive::FSlot Slot)")]
        public class FObjectThumbnail
        {
            public Int32 ImageWidth;
            public Int32 ImageHeight;
            [Sized] public byte[] CompressedImageData = [];
            [Sized] public byte[] ImageData = [];
        }
    }

    public static class ThumbnailTableExt
    {
        public static void Write(this BinaryWriter writer, ThumbnailTable item)
        {
            writer.Write(item.ThumbnailEntries.Count);
            foreach (ThumbnailEntry entry in item.ThumbnailEntries)
            {
                writer.Write(entry.ObjectShortClassName);
                writer.Write(entry.ObjectPathWithoutPackageName);
                writer.Write(entry.FileOffset);
            }
            for (int i = 0; i < item.ThumbnailEntries.Count; i++)
            {
                writer.BaseStream.Position = item.ThumbnailEntries[i].FileOffset;
                writer.WriteFields(item.Thumbnails[i]);
            }
        }

        public static ThumbnailTable Read(this BinaryReader reader, ThumbnailTable item)
        {
            item ??= new();
            item.ThumbnailEntries = Enumerable.Range(0, reader.ReadInt32()).Select(x => new ThumbnailEntry()).ToList();
            foreach (ThumbnailEntry entry in item.ThumbnailEntries)
            {
                reader.Read(entry.ObjectShortClassName);
                reader.Read(entry.ObjectPathWithoutPackageName);
                reader.Read(ref entry.FileOffset);
            }
            foreach (ThumbnailEntry entry in item.ThumbnailEntries)
            {
                reader.BaseStream.Position = entry.FileOffset;
                item.Thumbnails.Add(reader.ReadFields(new FObjectThumbnail()));
            }
            return item;
        }
    }
}
