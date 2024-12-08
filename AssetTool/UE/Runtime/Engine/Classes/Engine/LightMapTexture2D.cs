namespace AssetTool
{
    [JsonAsset("LightMapTexture2D")]
    public class ULightMapTexture2D : UTexture2D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}