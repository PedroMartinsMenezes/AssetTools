namespace AssetTool
{
    public static class FMath
    {
        public static ulong DivideAndRoundUp(ulong Dividend, ulong Divisor)
        {
            return (Dividend + Divisor - 1) / Divisor;
        }
    }
}
