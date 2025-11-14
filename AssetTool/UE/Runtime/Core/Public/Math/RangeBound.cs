using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("({Type} {Value})")]
    public class FFrameNumberRangeBound : ITransferable
    {
        public ERangeBoundType Type;
        public FFrameNumber Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    [DebuggerDisplay("({Type} {Value})")]
    public class FFloatRangeBound : ITransferable
    {
        public ERangeBoundType Type;
        public float Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    [DebuggerDisplay("({Type} {Value})")]
    public class FDoubleRangeBound : ITransferable
    {
        public ERangeBoundType Type;
        public double Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    [DebuggerDisplay("({Type} {Value})")]
    public class FInt32RangeBound : ITransferable
    {
        public ERangeBoundType Type;
        public int32 Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    public enum ERangeBoundType : byte
    {
        Exclusive,
        Inclusive,
        Open
    }
}
