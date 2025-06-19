namespace AssetTool
{
    [JsonAsset("NiagaraStackSummaryViewCollection")]
    public class UNiagaraStackSummaryViewCollection : UNiagaraStackValueCollection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}