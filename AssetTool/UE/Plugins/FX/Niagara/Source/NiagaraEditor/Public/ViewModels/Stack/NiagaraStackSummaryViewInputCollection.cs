namespace AssetTool
{
    [JsonAsset("NiagaraStackSummaryViewCollection")]
    public class UNiagaraStackSummaryViewCollection : UNiagaraStackValueCollection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}