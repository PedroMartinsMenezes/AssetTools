namespace AssetTool
{
    public class FRigVMOperand : ITransferible
    {
        public ERigVMMemoryType MemoryType;
        public UInt16 RegisterIndex;
        public UInt16 RegisterOffset;

        [Location("void FRigVMOperand::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            MemoryType = (ERigVMMemoryType)transfer.Move((byte)MemoryType);
            transfer.Move(ref RegisterIndex);
            transfer.Move(ref RegisterOffset);
            return this;
        }
    }

    public enum ERigVMMemoryType : byte
    {
        Work = 0,
        Literal = 1,
        External = 2,
        Debug = 3,
        Invalid
    };
}
