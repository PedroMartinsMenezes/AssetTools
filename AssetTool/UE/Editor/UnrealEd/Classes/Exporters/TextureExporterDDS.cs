namespace AssetTool
{
    [JsonAsset("TextureExporterDDS")]
    public class UTextureExporterDDS : UTextureExporterGeneric
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTextureBuilderExporterDDS")]
    public class UVirtualTextureBuilderExporterDDS : UTextureExporterDDS
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}