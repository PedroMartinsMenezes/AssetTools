namespace AssetTool
{
    [JsonAsset("NiagaraVolumeRendererProperties")]
    public class UNiagaraVolumeRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}