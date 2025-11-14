namespace AssetTool
{
    [JsonAsset("AssetDefinition_Texture2DArray")]
    public class UAssetDefinition_Texture2DArray : UAssetDefinition_Texture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}