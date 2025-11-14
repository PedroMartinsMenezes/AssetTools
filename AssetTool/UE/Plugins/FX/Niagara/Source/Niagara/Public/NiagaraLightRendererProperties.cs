namespace AssetTool
{
    [JsonAsset("NiagaraLightRendererProperties")]
    public class UNiagaraLightRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}