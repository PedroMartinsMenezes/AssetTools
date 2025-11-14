namespace AssetTool
{
    [JsonAsset("MaterialExpressionSpriteTextureSampler")]
    public class UMaterialExpressionSpriteTextureSampler : UMaterialExpressionTextureSampleParameter2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}