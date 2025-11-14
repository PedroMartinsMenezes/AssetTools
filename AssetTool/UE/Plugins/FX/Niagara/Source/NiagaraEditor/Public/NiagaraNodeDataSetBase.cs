namespace AssetTool
{
    [JsonAsset("NiagaraNodeDataSetBase")]
    public class UNiagaraNodeDataSetBase : UNiagaraNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}