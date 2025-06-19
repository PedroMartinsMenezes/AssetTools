namespace AssetTool
{
    [JsonAsset("TextureExporterDDS")]
    public class UTextureExporterDDS : UTextureExporterGeneric
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTextureBuilderExporterDDS")]
    public class UVirtualTextureBuilderExporterDDS : UTextureExporterDDS
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}