namespace AssetTool
{
    [JsonAsset("TextureExporterPNG")]
    public class UTextureExporterPNG : UTextureExporterGeneric
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTextureBuilderExporterPNG")]
    public class UVirtualTextureBuilderExporterPNG : UTextureExporterPNG
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureExporterJPEG")]
    public class UTextureExporterJPEG : UExporter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureExporterUEJPEG")]
    public class UTextureExporterUEJPEG : UExporter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}