namespace AssetTool
{
    public class FNiagaraCompileHash : ITransferible
    {
        public byte[] DataHash;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DataHash);
            return this;
        }
    }
}
