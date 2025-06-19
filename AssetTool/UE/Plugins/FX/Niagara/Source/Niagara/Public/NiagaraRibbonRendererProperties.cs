namespace AssetTool
{
    [JsonAsset("NiagaraRibbonRendererProperties")]
    public class UNiagaraRibbonRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}