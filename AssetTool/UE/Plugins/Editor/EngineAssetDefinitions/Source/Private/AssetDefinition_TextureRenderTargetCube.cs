namespace AssetTool
{
    [JsonAsset("AssetDefinition_TextureRenderTargetCube")]
    public class UAssetDefinition_TextureRenderTargetCube : UAssetDefinition_TextureRenderTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}