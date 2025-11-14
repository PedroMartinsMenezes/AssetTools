namespace AssetTool
{
    [TransferableStruct("NiagaraVariableCommonReference")]
    public class FNiagaraVariableCommonReference : ITransferable
    {
        public FName Name;
        public UInt32 UnderlyingType;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref UnderlyingType);
            return this;
        }
    }
}
