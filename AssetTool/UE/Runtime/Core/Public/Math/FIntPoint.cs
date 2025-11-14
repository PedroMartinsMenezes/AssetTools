using System.Diagnostics;

namespace AssetTool
{
    [TransferableStruct("IntPoint", size1: 8)]
    [DebuggerDisplay("({X} {Y})")]
    public class FIntPoint : ITransferable, ITagConverter
    {
        public const string StructName = "IntPoint";

        public int X;
        public int Y;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }
}
