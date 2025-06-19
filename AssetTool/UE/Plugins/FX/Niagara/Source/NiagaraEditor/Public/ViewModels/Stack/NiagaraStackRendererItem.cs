namespace AssetTool
{
    [JsonAsset("NiagaraStackRendererItem")]
    public class UNiagaraStackRendererItem : UNiagaraStackItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}