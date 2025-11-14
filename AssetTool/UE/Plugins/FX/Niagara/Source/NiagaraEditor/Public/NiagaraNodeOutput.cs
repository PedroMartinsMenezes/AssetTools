namespace AssetTool
{
    [JsonAsset("NiagaraNodeOutput")]
    public class UNiagaraNodeOutput : UNiagaraNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}