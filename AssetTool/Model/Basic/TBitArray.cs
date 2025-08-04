namespace AssetTool
{
    public class TBitArray : ITransferible
    {
        public Int32 NumBits;
        public UInt32[] Words = [];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NumBits);

            if (NumBits > 500000)
                throw new InvalidOperationException("Invalid NumBits");

            int count = NumWords(NumBits);

            transfer.Move(ref Words, count);

            return this;
        }

        private static int NumWords(int numBits)
        {
            return numBits == 0 ? 0 : (numBits % 32 == 0 ? numBits / 32 : 1 + numBits / 32);
        }
    }
}

