namespace AssetTool
{
    [JsonAsset("VirtualTexture")]
    public class UVirtualTexture : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LightMapVirtualTexture")]
    public class ULightMapVirtualTexture : UVirtualTexture
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RuntimeVirtualTextureStreamingProxy")]
    public class URuntimeVirtualTextureStreamingProxy : UTexture2D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VirtualTexture2D")]
    public class UVirtualTexture2D : UTexture2D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}