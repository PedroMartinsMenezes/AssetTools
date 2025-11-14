namespace AssetTool
{
    [TransferableStruct("PointerToUberGraphFrame")]
    public class FPointerToUberGraphFrame : ITransferable
    {
        public const string StructName = "PointerToUberGraphFrame";

        public UInt32 RawPointer;
        public UInt32 UberGraphFunctionKey;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref RawPointer);
            transfer.Move(ref UberGraphFunctionKey);
            return this;
        }
    }
}
