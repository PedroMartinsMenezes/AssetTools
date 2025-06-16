namespace AssetTool
{
    [JsonAsset("TextureExporterBMP")]
    public class UTextureExporterBMP : UTextureExporterGeneric
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTextureBuilderExporterBMP")]
    public class UVirtualTextureBuilderExporterBMP : UTextureExporterBMP
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}