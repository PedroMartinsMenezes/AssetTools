namespace AssetTool
{
    [JsonAsset("NiagaraNode")]
    public class UNiagaraNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}