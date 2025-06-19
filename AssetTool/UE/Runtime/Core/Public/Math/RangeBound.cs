namespace AssetTool
{
    public class FFrameNumberRangeBound : ITransferible
    {
        public ERangeBoundType Type;
        public FFrameNumber Value;

        public ITransferible Move(Transfer transfer)
        {
            Type = (ERangeBoundType)transfer.Move((byte)Type);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FFloatRangeBound : ITransferible
    {
        public ERangeBoundType Type;
        public float Value;

        public ITransferible Move(Transfer transfer)
        {
            Type = (ERangeBoundType)transfer.Move((byte)Type);
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
