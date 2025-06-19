namespace AssetTool
{
    [JsonAsset("TextureExporterEXR")]
    public class UTextureExporterEXR : UTextureExporterGeneric
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTextureBuilderExporterEXR")]
    public class UVirtualTextureBuilderExporterEXR : UTextureExporterEXR
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}