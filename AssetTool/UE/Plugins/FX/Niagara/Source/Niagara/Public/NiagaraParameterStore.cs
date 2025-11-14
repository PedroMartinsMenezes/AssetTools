namespace AssetTool
{
    [TransferableStruct("NiagaraVariableWithOffset")]
    public class FNiagaraVariableWithOffset : FNiagaraVariableBase
    {
        public Int32 Offset;

        [Location("bool FNiagaraVariableWithOffset::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.VariablesUseTypeDefRegistry)
            {
                transfer.Move(ref Offset);
                return this;
            }
            return default;
        }
    }
}