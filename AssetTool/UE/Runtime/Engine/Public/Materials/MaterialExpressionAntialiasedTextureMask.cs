namespace AssetTool
{
    [JsonAsset("MaterialExpressionAntialiasedTextureMask")]
    public class UMaterialExpressionAntialiasedTextureMask : UMaterialExpressionTextureSampleParameter2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}