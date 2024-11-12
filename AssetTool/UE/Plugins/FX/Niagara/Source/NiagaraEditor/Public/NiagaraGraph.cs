namespace AssetTool
{
    [JsonAsset("NiagaraGraph")]
    public class UNiagaraGraph : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}