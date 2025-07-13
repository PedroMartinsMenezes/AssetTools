namespace AssetTool
{
    [JsonAsset("AssetDefinition_TextureCube")]
    public class UAssetDefinition_TextureCube : UAssetDefinition_Texture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}