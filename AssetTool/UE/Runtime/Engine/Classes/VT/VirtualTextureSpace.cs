namespace AssetTool
{
    [JsonAsset("VirtualTextureSpace ")]
    public class UVirtualTextureSpace : UObject
    {
        public EPixelFormat[] LayerFormats;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveEnum(ref LayerFormats);
            return this;
        }
    }

    [JsonAsset("LightMapVirtualTextureSpace")]
    public class ULightMapVirtualTextureSpace : UVirtualTextureSpace
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}