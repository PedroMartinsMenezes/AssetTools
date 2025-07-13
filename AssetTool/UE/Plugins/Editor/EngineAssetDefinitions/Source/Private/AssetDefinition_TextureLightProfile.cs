namespace AssetTool
{
    [JsonAsset("AssetDefinition_TextureLightProfile")]
    public class UAssetDefinition_TextureLightProfile : UAssetDefinition_Texture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}