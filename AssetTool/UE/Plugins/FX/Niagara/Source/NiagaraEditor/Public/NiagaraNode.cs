namespace AssetTool
{
    [JsonAsset("NiagaraNode")]
    public class UNiagaraNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}