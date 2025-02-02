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
    public class ULightMapVirtualTexture : UVirtualTexture, ITransferible
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        ITransferible ITransferible.Move(Transfer transfer)
        {
            return (ITransferible)Move(transfer);
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