namespace AssetTool
{
    [JsonAsset("NiagaraVolumeRendererProperties")]
    public class UNiagaraVolumeRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}