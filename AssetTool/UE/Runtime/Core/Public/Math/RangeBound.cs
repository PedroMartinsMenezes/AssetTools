using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("({Type} {Value})")]
    public class FFrameNumberRangeBound : ITransferible
    {
        public ERangeBoundType Type;
        public FFrameNumber Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    [DebuggerDisplay("({Type} {Value})")]
    public class FFloatRangeBound : ITransferible
    {
        public ERangeBoundType Type;
        public float Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    [DebuggerDisplay("({Type} {Value})")]
    public class FDoubleRangeBound : ITransferible
    {
        public ERangeBoundType Type;
        public double Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    [DebuggerDisplay("({Type} {Value})")]
    public class FInt32RangeBound : ITransferible
    {
        public ERangeBoundType Type;
        public int32 Value;

        public ITransferible Move(Transfer transfer)
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
