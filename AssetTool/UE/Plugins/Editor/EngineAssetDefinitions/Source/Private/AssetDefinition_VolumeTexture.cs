namespace AssetTool
{
    [JsonAsset("AssetDefinition_VolumeTexture")]
    public class UAssetDefinition_VolumeTexture : UAssetDefinition_Texture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}