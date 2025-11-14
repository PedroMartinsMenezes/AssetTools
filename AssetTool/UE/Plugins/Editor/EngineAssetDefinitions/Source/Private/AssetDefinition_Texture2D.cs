namespace AssetTool
{
    [JsonAsset("AssetDefinition_Texture2D")]
    public class UAssetDefinition_Texture2D : UAssetDefinition_Texture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}