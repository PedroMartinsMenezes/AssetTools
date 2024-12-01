namespace AssetTool
{
    public class FNiagaraCompileHash : ITransferible
    {
        public List<byte> DataHash;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DataHash);
            return this;
        }
    }
}
