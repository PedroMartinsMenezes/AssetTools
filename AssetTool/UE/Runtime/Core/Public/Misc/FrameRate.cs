namespace AssetTool
{
    public class FFrameRate : ITransferible
    {
        public Int32 Numerator;
        public Int32 Denominator;

        [Location("bool FFrameRate::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Numerator);
            transfer.Move(ref Denominator);
            return this;
        }
    }
}
