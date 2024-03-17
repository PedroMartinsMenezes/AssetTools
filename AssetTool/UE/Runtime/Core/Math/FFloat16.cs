namespace AssetTool
{
    public class FFloat16
    {
        public UInt16 Encoded;

        public FFloat16 Read(BinaryReader reader)
        {
            Encoded = reader.ReadUInt16();
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(Encoded);
        }
    }
}
