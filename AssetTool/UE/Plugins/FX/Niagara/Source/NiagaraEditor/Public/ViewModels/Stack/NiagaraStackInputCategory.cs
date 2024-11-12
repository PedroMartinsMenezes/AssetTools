namespace AssetTool
{
    [JsonAsset("NiagaraStackCategory")]
    public class UNiagaraStackCategory : UNiagaraStackItemContent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackInputCategory")]
    public class UNiagaraStackInputCategory : UNiagaraStackCategory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackSummaryCategory")]
    public class UNiagaraStackSummaryCategory : UNiagaraStackCategory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}