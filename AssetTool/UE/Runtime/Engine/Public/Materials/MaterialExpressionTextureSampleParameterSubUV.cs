namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameterSubUV")]
    public class UMaterialExpressionTextureSampleParameterSubUV : UMaterialExpressionTextureSampleParameter2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}