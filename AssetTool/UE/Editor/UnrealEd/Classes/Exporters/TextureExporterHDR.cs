namespace AssetTool
{
    [JsonAsset("TextureExporterHDR")]
    public class UTextureExporterHDR : UTextureExporterGeneric
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTextureBuilderExporterHDR")]
    public class UVirtualTextureBuilderExporterHDR : UTextureExporterHDR
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}