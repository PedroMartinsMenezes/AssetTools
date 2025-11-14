namespace AssetTool
{
    [JsonAsset("NiagaraStackRendererItem")]
    public class UNiagaraStackRendererItem : UNiagaraStackItem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}