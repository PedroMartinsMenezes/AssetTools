namespace AssetTool
{
    [JsonAsset("NiagaraNodeOutput")]
    public class UNiagaraNodeOutput : UNiagaraNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}