namespace AssetTool
{
    public class FFrameNumberRange : ITransferible
    {
        public FFrameNumberRangeBound LowerBound;
        public FFrameNumberRangeBound UpperBound;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }
}
