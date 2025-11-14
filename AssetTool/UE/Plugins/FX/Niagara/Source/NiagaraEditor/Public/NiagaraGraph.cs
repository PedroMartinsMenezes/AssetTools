namespace AssetTool
{
    [JsonAsset("NiagaraGraph")]
    public class UNiagaraGraph : UEdGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}