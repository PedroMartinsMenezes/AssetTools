namespace AssetTool
{
    [JsonAsset("NiagaraOverviewNode")]
    public class UNiagaraOverviewNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}