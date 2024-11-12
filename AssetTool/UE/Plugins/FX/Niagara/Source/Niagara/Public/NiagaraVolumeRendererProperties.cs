namespace AssetTool
{
    [JsonAsset("NiagaraVolumeRendererProperties")]
    public class UNiagaraVolumeRendererProperties : UNiagaraRendererProperties
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}