namespace AssetTool
{
    public class TBitArray
    {
        public Int32 NumBits;
        public UInt32[] Words = [];

        public void Move(Transfer transfer)
        {
            transfer.Move(ref NumBits);

            if (NumBits > 100000)
                throw new InvalidOperationException("Invalid NumBits");

            int count = NumWords(NumBits);

            transfer.Move(ref Words, count);
        }

        private static int NumWords(int numBits)
        {
            return numBits == 0 ? 0 : 1 + numBits / 32;
        }
    }
}

