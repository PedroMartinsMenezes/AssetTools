namespace AssetTool
{
    [TransferibleStruct("FrameNumber")]
    public struct FFrameNumber : ITransferible, ITransferibleRaw
    {
        public static readonly int Size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(FFrameNumber));

        public Int32 Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }

        public ITransferible MoveRaw(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
