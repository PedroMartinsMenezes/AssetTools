namespace AssetTool
{
    public static class FMath
    {
        public static long DivideAndRoundUp(long Dividend, long Divisor)
        {
            return (Dividend + Divisor - 1) / Divisor;
        }
    }
}
