namespace AssetTool
{
    [JsonAsset("MaterialExpressionSpriteTextureSampler")]
    public class UMaterialExpressionSpriteTextureSampler : UMaterialExpressionTextureSampleParameter2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}