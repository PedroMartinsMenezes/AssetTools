namespace AssetTool
{
    [JsonAsset("AssetDefinition_TextureRenderTargetVolume")]
    public class UAssetDefinition_TextureRenderTargetVolume : UAssetDefinition_TextureRenderTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}