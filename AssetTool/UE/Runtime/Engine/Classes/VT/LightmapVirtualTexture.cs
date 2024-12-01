namespace AssetTool
{
    [JsonAsset("LightMapVirtualTexture2D")]
    public class ULightMapVirtualTexture2D : UTexture2D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}