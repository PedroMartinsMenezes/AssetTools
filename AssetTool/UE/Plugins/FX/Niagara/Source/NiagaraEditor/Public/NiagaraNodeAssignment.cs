namespace AssetTool
{
    [JsonAsset("NiagaraNodeAssignment")]
    public class UNiagaraNodeAssignment : UNiagaraNodeFunctionCall
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}