namespace AssetTool
{
    [JsonAsset("NiagaraNodeAssignment")]
    public class UNiagaraNodeAssignment : UNiagaraNodeFunctionCall
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}