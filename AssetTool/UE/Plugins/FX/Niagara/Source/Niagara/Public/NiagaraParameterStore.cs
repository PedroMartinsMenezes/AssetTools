namespace AssetTool
{
    [TransferibleStruct("NiagaraVariableWithOffset")]
    public class FNiagaraVariableWithOffset : FNiagaraVariableBase
    {
        public Int32 Offset;

        [Location("bool FNiagaraVariableWithOffset::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.VariablesUseTypeDefRegistry)
            {
                transfer.Move(ref Offset);
            }
            return this;
        }
    }
}