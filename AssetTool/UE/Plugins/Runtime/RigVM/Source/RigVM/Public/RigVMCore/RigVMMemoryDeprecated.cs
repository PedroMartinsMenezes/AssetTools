namespace AssetTool
{
    public class FRigVMMemoryContainer : ITransferible
    {
        public ITransferible Move(Transfer transfer)
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