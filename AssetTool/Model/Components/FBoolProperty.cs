namespace AssetTool
{
    [Location("void FBoolProperty::Serialize( FArchive& Ar )")]
    public class FBoolProperty : FProperty
    {
        public const string TYPE_NAME = "BoolProperty";
        public override string TypeName => TYPE_NAME;

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
            writer.Write((FProperty)item);

            writer.Write(item.FieldSize);
            writer.Write(item.ByteOffset);
            writer.Write(item.ByteMask);
            writer.Write(item.FieldMask);
            writer.Write(item.BoolSize);
            writer.Write(item.NativeBool);
        }

        public static FBoolProperty Read(this BinaryReader reader, FBoolProperty item)
        {
            reader.Read((FProperty)item);

            reader.Read(ref item.FieldSize);
            reader.Read(ref item.ByteOffset);
            reader.Read(ref item.ByteMask);
            reader.Read(ref item.FieldMask);
            reader.Read(ref item.BoolSize);
            reader.Read(ref item.NativeBool);
            return item;
        }
    }
}
