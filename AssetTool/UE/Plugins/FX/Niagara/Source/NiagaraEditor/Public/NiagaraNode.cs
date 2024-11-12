namespace AssetTool
{
    [JsonAsset("NiagaraNode")]
    public class UNiagaraNode : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}