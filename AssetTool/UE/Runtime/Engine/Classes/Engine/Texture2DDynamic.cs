namespace AssetTool
{
    [JsonAsset("Texture2DDynamic")]
    public class UTexture2DDynamic : UTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}