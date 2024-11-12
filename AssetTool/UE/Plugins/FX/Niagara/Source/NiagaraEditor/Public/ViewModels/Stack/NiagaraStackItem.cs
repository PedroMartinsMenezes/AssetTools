namespace AssetTool
{
    [JsonAsset("NiagaraStackItem")]
    public class UNiagaraStackItem : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackItemContent")]
    public class UNiagaraStackItemContent : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackItemTextContent")]
    public class UNiagaraStackItemTextContent : UNiagaraStackItemContent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}