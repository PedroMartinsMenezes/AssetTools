using System.Diagnostics;

namespace AssetTool
{
    [TransferibleStruct("FrameNumber")]
    [DebuggerDisplay("{Value}")]
    public struct FFrameNumber : ITransferible
    {
        public static readonly int Size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(FFrameNumber));

        public Int32 Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
