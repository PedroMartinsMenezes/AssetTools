namespace AssetTool
{
    [JsonAsset("NiagaraStackEventWrapper")]
    public class UNiagaraStackEventWrapper : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackEventHandlerPropertiesItem")]
    public class UNiagaraStackEventHandlerPropertiesItem : UNiagaraStackItem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}