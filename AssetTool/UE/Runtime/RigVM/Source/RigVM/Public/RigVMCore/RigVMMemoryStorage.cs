namespace AssetTool
{
    public class FRigVMBranchInfo : ITransferible
    {
        public Int32 Index;
        public FString LabelString;
        public Int32 InstructionIndex;
        public Int32 ArgumentIndex;
        public UInt16 FirstInstruction;
        public UInt16 LastInstruction;

        [Location("void FRigVMBranchInfo::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            transfer.Move(ref LabelString);
            transfer.Move(ref InstructionIndex);
            transfer.Move(ref ArgumentIndex);
            transfer.Move(ref FirstInstruction);
            transfer.Move(ref LastInstruction);
            return this;
        }
    }
}
