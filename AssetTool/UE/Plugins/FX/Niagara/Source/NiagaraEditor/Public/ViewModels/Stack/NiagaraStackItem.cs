namespace AssetTool
{
    [JsonAsset("NiagaraStackItem")]
    public class UNiagaraStackItem : UNiagaraStackEntry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackItemContent")]
    public class UNiagaraStackItemContent : UNiagaraStackEntry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackItemTextContent")]
    public class UNiagaraStackItemTextContent : UNiagaraStackItemContent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}