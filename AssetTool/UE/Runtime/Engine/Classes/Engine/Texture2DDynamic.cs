namespace AssetTool
{
    [JsonAsset("Texture2DDynamic")]
    public class UTexture2DDynamic : UTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}