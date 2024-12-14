namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureObjectParameter")]
    public class UMaterialExpressionTextureObjectParameter : UMaterialExpressionTextureSampleParameter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}