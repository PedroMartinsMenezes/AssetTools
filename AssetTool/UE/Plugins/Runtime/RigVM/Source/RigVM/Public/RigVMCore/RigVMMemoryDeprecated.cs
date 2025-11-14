namespace AssetTool
{
    public class FRigVMMemoryContainer : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public enum ERigVMRegisterType : byte
    {
        Plain,
        String,
        Name,
        Struct,
        Invalid
    }
}