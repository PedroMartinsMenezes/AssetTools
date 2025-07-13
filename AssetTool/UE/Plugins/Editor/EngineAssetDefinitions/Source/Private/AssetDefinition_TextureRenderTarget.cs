namespace AssetTool
{
    [JsonAsset("AssetDefinition_TextureRenderTarget")]
    public class UAssetDefinition_TextureRenderTarget : UAssetDefinition_Texture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}