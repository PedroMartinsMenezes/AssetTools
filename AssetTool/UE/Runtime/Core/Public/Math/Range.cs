using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
    public class FFloatRange : ITransferible
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

    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
    public class FDoubleRange : ITransferible
    {
        public FDoubleRangeBound LowerBound;
        public FDoubleRangeBound UpperBound;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }

    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
    public class FInt32Range : ITransferible
    {
        public FInt32RangeBound LowerBound;
        public FInt32RangeBound UpperBound;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }

    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
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
