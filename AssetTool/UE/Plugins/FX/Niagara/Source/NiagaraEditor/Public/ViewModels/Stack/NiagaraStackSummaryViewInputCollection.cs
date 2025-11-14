namespace AssetTool
{
    [JsonAsset("NiagaraStackSummaryViewCollection")]
    public class UNiagaraStackSummaryViewCollection : UNiagaraStackValueCollection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}