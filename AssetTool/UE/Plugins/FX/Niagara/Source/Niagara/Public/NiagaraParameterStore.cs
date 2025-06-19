namespace AssetTool
{
    [TransferibleStruct("NiagaraVariableWithOffset")]
    public class FNiagaraVariableWithOffset : FNiagaraVariableBase
    {
        public Int32 Offset;

        [Location("bool FNiagaraVariableWithOffset::Serialize(FArchive& Ar)")]
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);
            if (transfer.Supports.VariablesUseTypeDefRegistry)
            {
                transfer.Move(ref Offset);
                return this;
            }
            return null;
        }
    }
}