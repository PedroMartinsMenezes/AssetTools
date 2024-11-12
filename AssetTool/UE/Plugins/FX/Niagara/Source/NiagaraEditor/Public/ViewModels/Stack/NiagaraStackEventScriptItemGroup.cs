namespace AssetTool
{
    [JsonAsset("NiagaraStackEventWrapper")]
    public class UNiagaraStackEventWrapper : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackEventHandlerPropertiesItem")]
    public class UNiagaraStackEventHandlerPropertiesItem : UNiagaraStackItem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}