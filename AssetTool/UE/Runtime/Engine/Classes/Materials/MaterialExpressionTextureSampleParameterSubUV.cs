namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameterSubUV")]
    public class UMaterialExpressionTextureSampleParameterSubUV : UMaterialExpressionTextureSampleParameter2D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}