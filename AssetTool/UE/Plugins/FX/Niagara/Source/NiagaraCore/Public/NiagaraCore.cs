namespace AssetTool
{
    [TransferibleStruct("NiagaraVariableCommonReference")]
    public class FNiagaraVariableCommonReference : ITransferible
    {
        public FName Name;
        public UInt32 UnderlyingType;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref UnderlyingType);
            return this;
        }
    }
}
