namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameter")]
    public class UMaterialExpressionTextureSampleParameter : UMaterialExpressionTextureSample
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}