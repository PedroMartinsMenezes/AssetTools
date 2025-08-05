namespace AssetTool
{
    public class FRigVMBranchInfo : ITransferible
    {
        public Int32 Index;
        public FString LabelString;
        public Int32 InstructionIndex;
        public Int32 ArgumentIndex;
        public Int32 FirstInstruction;
        public Int32 LastInstruction;

        [Location("void FRigVMBranchInfo::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            transfer.Move(ref LabelString);
            transfer.Move(ref InstructionIndex);
            transfer.Move(ref ArgumentIndex);

            if (!transfer.Supports.ByteCodeCleanup)
            {
                transfer.MoveAsUInt16(ref FirstInstruction);
                transfer.MoveAsUInt16(ref LastInstruction);
            }
            else
            {
                transfer.Move(ref FirstInstruction);
                transfer.Move(ref LastInstruction);
            }

            return this;
        }
    }
}
