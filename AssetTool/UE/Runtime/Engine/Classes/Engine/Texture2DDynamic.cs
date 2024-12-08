namespace AssetTool
{
    [JsonAsset("Texture2DDynamic")]
    public class UTexture2DDynamic : UTexture
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}