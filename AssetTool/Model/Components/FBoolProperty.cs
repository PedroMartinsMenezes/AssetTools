using System.ComponentModel;

namespace AssetTool
{
    [Description("void FBoolProperty::Serialize( FArchive& Ar )")]
    public class FBoolProperty : FProperty
    {
        public byte FieldSize;
        public byte ByteOffset;
        public byte ByteMask;
        public byte FieldMask;
        public byte BoolSize;
        public byte NativeBool;
    }

    public static class FBoolPropertyExt
    {
        public static void Write(this BinaryWriter writer, FBoolProperty item)
        {
            writer.Write(item.FieldSize);
            writer.Write(item.ByteOffset);
            writer.Write(item.ByteMask);
            writer.Write(item.FieldMask);
            writer.Write(item.BoolSize);
            writer.Write(item.NativeBool);
        }

        public static void Read(this BinaryReader reader, FBoolProperty item)
        {
            reader.Read(ref item.FieldSize);
            reader.Read(ref item.ByteOffset);
            reader.Read(ref item.ByteMask);
            reader.Read(ref item.FieldMask);
            reader.Read(ref item.BoolSize);
            reader.Read(ref item.NativeBool);
        }
    }
}
