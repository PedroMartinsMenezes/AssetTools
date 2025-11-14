namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameterSubUV")]
    public class UMaterialExpressionTextureSampleParameterSubUV : UMaterialExpressionTextureSampleParameter2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}