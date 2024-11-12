namespace AssetTool
{
    [JsonAsset("NiagaraStackErrorItem")]
    public class UNiagaraStackErrorItem : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackErrorItemLongDescription")]
    public class UNiagaraStackErrorItemLongDescription : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackErrorItemFix")]
    public class UNiagaraStackErrorItemFix : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackErrorItemDismiss")]
    public class UNiagaraStackErrorItemDismiss : UNiagaraStackErrorItemFix
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}