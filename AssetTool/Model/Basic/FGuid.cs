namespace AssetTool
{
    public struct FGuid
    {
        public Guid Value;

        public FGuid(Guid value)
        {
            Value = value;
        }

        public FGuid(byte[] bytes)
        {
            (byte b4, byte b5, byte b6, byte b7) = (bytes[4], bytes[5], bytes[6], bytes[7]);
            (bytes[4], bytes[5], bytes[6], bytes[7]) = (b6, b7, b4, b5);

            (byte b8, byte b9, byte b10, byte b11) = (bytes[8], bytes[9], bytes[10], bytes[11]);
            (bytes[8], bytes[9], bytes[10], bytes[11]) = (b11, b10, b9, b8);

            (byte b12, byte b13, byte b14, byte b15) = (bytes[12], bytes[13], bytes[14], bytes[15]);
            (bytes[12], bytes[13], bytes[14], bytes[15]) = (b15, b14, b13, b12);

            Value = new Guid(bytes);
        }

        public static implicit operator FGuid(Guid value) => new FGuid(value);

        public byte[] ToByteArray()
        {
            var bytes = Value.ToByteArray();
            (byte b4, byte b5, byte b6, byte b7) = (bytes[4], bytes[5], bytes[6], bytes[7]);
            (bytes[4], bytes[5], bytes[6], bytes[7]) = (b6, b7, b4, b5);
            (byte b8, byte b9, byte b10, byte b11) = (bytes[8], bytes[9], bytes[10], bytes[11]);
            (bytes[8], bytes[9], bytes[10], bytes[11]) = (b11, b10, b9, b8);
            (byte b12, byte b13, byte b14, byte b15) = (bytes[12], bytes[13], bytes[14], bytes[15]);
            (bytes[12], bytes[13], bytes[14], bytes[15]) = (b15, b14, b13, b12);
            return bytes;
        }
    }

    public static class FGuidExt
    {
        public static void Write(this BinaryWriter writer, FGuid guid)
        {
            var bytes = guid.ToByteArray();
            writer.Write(bytes);
        }

        public static void Read(this BinaryReader reader, ref FGuid item)
        {
            item = new FGuid(reader.ReadBytes(16));
        }
    }
}
