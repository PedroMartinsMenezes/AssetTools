namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameter")]
    public class UMaterialExpressionTextureSampleParameter : UMaterialExpressionTextureSample
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}