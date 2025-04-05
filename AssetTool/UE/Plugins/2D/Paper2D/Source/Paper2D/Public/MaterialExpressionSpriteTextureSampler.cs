namespace AssetTool
{
    [JsonAsset("MaterialExpressionSpriteTextureSampler")]
    public class UMaterialExpressionSpriteTextureSampler : UMaterialExpressionTextureSampleParameter2D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}