namespace AssetTool
{
    public class TBitArray
    {
        public Int32 NumBits;
        [Check("NumBitsCheck")] public Int32 MaxBits;

        public bool NumBitsCheck()
        {
            return NumBits > 0;
        }
    }
}
