namespace AssetTool
{
    [JsonAsset("NiagaraRibbonRendererProperties")]
    public class UNiagaraRibbonRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}