namespace AssetTool
{
    [JsonAsset("RenderTargetExporterPNG")]
    public class URenderTargetExporterPNG : UExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RenderTargetExporterEXR")]
    public class URenderTargetExporterEXR : UExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}