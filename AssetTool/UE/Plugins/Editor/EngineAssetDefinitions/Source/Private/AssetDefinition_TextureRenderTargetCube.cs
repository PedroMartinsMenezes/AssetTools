namespace AssetTool
{
    [JsonAsset("AssetDefinition_TextureRenderTargetCube")]
    public class UAssetDefinition_TextureRenderTargetCube : UAssetDefinition_TextureRenderTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}