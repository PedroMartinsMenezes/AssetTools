using System.Diagnostics;

namespace AssetTool
{
    [TransferibleStruct("IntPoint", size1: 8)]
    [DebuggerDisplay("({X} {Y})")]
    public class FIntPoint : ITransferible, ITagConverter
    {
        public const string StructName = "IntPoint";

        public int X;
        public int Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }
}
