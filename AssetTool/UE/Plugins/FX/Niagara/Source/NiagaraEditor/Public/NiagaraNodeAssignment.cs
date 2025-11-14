namespace AssetTool
{
    [JsonAsset("NiagaraNodeAssignment")]
    public class UNiagaraNodeAssignment : UNiagaraNodeFunctionCall
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}