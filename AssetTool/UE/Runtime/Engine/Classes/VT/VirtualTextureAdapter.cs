namespace AssetTool
{
    [JsonAsset("VirtualTextureAdapter")]
    public class UVirtualTextureAdapter : UTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}