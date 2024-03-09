namespace AssetTool
{
    public class TBitArray
    {
        public int SizeOf() => 4 + Words.Length * 4;

        public Int32 NumBits;
        public UInt32[] Words;

        public void Read(BinaryReader reader)
        {
            NumBits = reader.ReadInt32();

            int count = NumWords(NumBits);
            Words = new UInt32[count];
            for (int i = 0; i < count; i++)
            {
                Words[i] = reader.ReadUInt32();
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(NumBits);
            Words.ToList().ForEach(writer.Write);
        }

        private int NumWords(int numBits)
        {
            return numBits == 0 ? 0 : 1 + numBits / 32;
        }
    }
}
