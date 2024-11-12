namespace AssetTool
{
    [JsonAsset("NiagaraDecalRendererProperties")]
    public class UNiagaraDecalRendererProperties : UNiagaraRendererProperties
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}