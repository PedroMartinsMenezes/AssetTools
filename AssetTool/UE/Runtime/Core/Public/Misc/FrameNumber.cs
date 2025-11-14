using System.Diagnostics;

namespace AssetTool
{
    [TransferableStruct("FrameNumber")]
    [DebuggerDisplay("{Value}")]
    public struct FFrameNumber : ITransferable
    {
        public static readonly int Size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(FFrameNumber));

        public Int32 Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
