namespace AssetTool
{
    public class FNiagaraCompileHash : ITransferible
    {
        public byte[] DataHash;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref DataHash);
            return this;
        }
    }
}
