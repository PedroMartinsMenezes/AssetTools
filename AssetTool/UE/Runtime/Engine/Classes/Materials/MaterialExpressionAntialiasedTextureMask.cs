namespace AssetTool
{
    [JsonAsset("MaterialExpressionAntialiasedTextureMask")]
    public class UMaterialExpressionAntialiasedTextureMask : UMaterialExpressionTextureSampleParameter2D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}