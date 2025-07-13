namespace AssetTool
{
    [JsonAsset("AssetDefinition_CanvasRenderTarget2D")]
    public class UAssetDefinition_CanvasRenderTarget2D : UAssetDefinition_TextureRenderTarget2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}