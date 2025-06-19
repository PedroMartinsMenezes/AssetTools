namespace AssetTool
{
    [JsonAsset("TextureExporterPNG")]
    public class UTextureExporterPNG : UTextureExporterGeneric
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTextureBuilderExporterPNG")]
    public class UVirtualTextureBuilderExporterPNG : UTextureExporterPNG
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureExporterJPEG")]
    public class UTextureExporterJPEG : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureExporterUEJPEG")]
    public class UTextureExporterUEJPEG : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}