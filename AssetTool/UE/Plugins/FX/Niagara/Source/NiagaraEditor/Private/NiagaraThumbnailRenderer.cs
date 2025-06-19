namespace AssetTool
{
    [JsonAsset("NiagaraThumbnailRendererBase")]
    public class UNiagaraThumbnailRendererBase : UTextureThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraEmitterThumbnailRenderer")]
    public class UNiagaraEmitterThumbnailRenderer : UNiagaraThumbnailRendererBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSystemThumbnailRenderer")]
    public class UNiagaraSystemThumbnailRenderer : UNiagaraThumbnailRendererBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}