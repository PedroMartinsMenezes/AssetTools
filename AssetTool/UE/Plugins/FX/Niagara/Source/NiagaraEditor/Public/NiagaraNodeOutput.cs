namespace AssetTool
{
    [JsonAsset("NiagaraNodeOutput")]
    public class UNiagaraNodeOutput : UNiagaraNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}