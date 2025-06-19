namespace AssetTool
{
    public class FRigVMMemoryContainer : ITransferible
    {
        public ITransferible Move2(Transfer transfer)
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