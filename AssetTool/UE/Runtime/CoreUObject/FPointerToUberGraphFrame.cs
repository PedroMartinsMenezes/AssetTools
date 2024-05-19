namespace AssetTool
{
    public class FPointerToUberGraphFrame
    {
        public const string StructName = "PointerToUberGraphFrame";

        public UInt32 RawPointer;
        public UInt32 UberGraphFunctionKey;

        public FPointerToUberGraphFrame Move(Transfer transfer)
        {
            transfer.Move(ref RawPointer);
            transfer.Move(ref UberGraphFunctionKey);
            return this;
        }
    }
}
