namespace AssetTool
{
    [JsonAsset("TextureCubeExporterHDR")]
    public class UTextureCubeExporterHDR : UExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RenderTargetCubeExporterHDR")]
    public class URenderTargetCubeExporterHDR : UTextureCubeExporterHDR
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}