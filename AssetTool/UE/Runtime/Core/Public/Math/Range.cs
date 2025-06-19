namespace AssetTool
{
    public class TRangeFloat : ITransferible
    {
        public FFloatRangeBound LowerBound;
        public FFloatRangeBound UpperBound;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }
}
