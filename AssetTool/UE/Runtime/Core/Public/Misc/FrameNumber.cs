namespace AssetTool
{
    [TransferibleStruct("FrameNumber")]
    public class FFrameNumber : ITransferible
    {
        public const int Size = 4;

        public Int32 Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
