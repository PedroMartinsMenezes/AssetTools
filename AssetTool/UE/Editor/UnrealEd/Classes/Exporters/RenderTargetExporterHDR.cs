namespace AssetTool
{
    [JsonAsset("RenderTargetExporterPNG")]
    public class URenderTargetExporterPNG : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RenderTargetExporterEXR")]
    public class URenderTargetExporterEXR : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}