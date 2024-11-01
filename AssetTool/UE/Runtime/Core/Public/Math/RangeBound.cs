namespace AssetTool
{
    public class FFrameNumberRangeBound : ITransferible
    {
        public byte Type;
        public FFrameNumber Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Type);
            transfer.Move(ref Value);
            return this;
        }
    }
}
