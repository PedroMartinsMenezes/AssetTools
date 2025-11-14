namespace AssetTool
{
    public class FFrameRate : ITransferable
    {
        public Int32 Numerator;
        public Int32 Denominator;

        [Location("bool FFrameRate::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Numerator);
            transfer.Move(ref Denominator);
            return this;
        }
    }
}
