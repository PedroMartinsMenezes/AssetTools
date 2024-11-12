namespace AssetTool
{
    [JsonAsset("NiagaraRibbonRendererProperties")]
    public class UNiagaraRibbonRendererProperties : UNiagaraRendererProperties
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}