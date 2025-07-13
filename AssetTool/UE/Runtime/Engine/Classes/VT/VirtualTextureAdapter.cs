namespace AssetTool
{
    [JsonAsset("VirtualTextureAdapter")]
    public class UVirtualTextureAdapter : UTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}