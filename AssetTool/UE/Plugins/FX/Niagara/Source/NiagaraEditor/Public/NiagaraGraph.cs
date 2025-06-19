namespace AssetTool
{
    [JsonAsset("NiagaraGraph")]
    public class UNiagaraGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}