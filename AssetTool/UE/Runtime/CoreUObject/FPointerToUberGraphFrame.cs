namespace AssetTool
{
    [StructSerializable("PointerToUberGraphFrame")]
    public class FPointerToUberGraphFrame : ITransferible
    {
        public const string StructName = "PointerToUberGraphFrame";

        public UInt32 RawPointer;
        public UInt32 UberGraphFunctionKey;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref RawPointer);
            transfer.Move(ref UberGraphFunctionKey);
            return this;
        }
    }
}
