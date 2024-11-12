namespace AssetTool
{
    [JsonAsset("NiagaraNodeDataSetBase")]
    public class UNiagaraNodeDataSetBase : UNiagaraNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}