namespace AssetTool
{
    [JsonAsset("NiagaraLightRendererProperties")]
    public class UNiagaraLightRendererProperties : UNiagaraRendererProperties
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}