using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{Encoded}")]
    public struct FFloat16 : ITransferible
    {
        public UInt16 Encoded;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Encoded);
            return this;
        }
    }
}
