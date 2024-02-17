namespace AssetTool
{
    public class TBitArray
    {
        public int SizeOf() => NumBits > 0 ? 8 : 4;

        public Int32 NumBits;
        [Check("NumBitsCheck")] public Int32 MaxBits;

        public bool NumBitsCheck()
        {
            return NumBits > 0;
        }
    }
}
