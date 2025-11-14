namespace AssetTool
{
    [JsonAsset("AssetDefinition_TextureCubeArray")]
    public class UAssetDefinition_TextureCubeArray : UAssetDefinition_Texture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}