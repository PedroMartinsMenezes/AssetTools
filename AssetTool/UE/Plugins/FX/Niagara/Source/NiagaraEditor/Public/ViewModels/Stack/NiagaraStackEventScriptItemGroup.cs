namespace AssetTool
{
    [JsonAsset("NiagaraStackEventWrapper")]
    public class UNiagaraStackEventWrapper : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackEventHandlerPropertiesItem")]
    public class UNiagaraStackEventHandlerPropertiesItem : UNiagaraStackItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}