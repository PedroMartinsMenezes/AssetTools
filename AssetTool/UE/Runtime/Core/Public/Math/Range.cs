using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
    public class FFloatRange : ITransferable
    {
        public FFloatRangeBound LowerBound;
        public FFloatRangeBound UpperBound;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }

    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
    public class FDoubleRange : ITransferable
    {
        public FDoubleRangeBound LowerBound;
        public FDoubleRangeBound UpperBound;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }

    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
    public class FInt32Range : ITransferable
    {
        public FInt32RangeBound LowerBound;
        public FInt32RangeBound UpperBound;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }

    [DebuggerDisplay("Lower{LowerBound} Upper{UpperBound}")]
    public class FFrameNumberRange : ITransferable
    {
        public FFrameNumberRangeBound LowerBound;
        public FFrameNumberRangeBound UpperBound;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref LowerBound);
            transfer.Move(ref UpperBound);
            return this;
        }
    }
}
