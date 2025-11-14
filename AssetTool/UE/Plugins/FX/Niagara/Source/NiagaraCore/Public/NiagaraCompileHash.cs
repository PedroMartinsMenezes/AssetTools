namespace AssetTool
{
    public class FNiagaraCompileHash : ITransferable
    {
        public byte[] DataHash;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref DataHash);
            return this;
        }
    }
}
