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

        public new FBoolProperty Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref FieldSize);
            reader.Read(ref ByteOffset);
            reader.Read(ref ByteMask);
            reader.Read(ref FieldMask);
            reader.Read(ref BoolSize);
            reader.Read(ref NativeBool);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(FieldSize);
            writer.Write(ByteOffset);
            writer.Write(ByteMask);
            writer.Write(FieldMask);
            writer.Write(BoolSize);
            writer.Write(NativeBool);
        }
    }
}
