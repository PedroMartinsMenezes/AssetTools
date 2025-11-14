namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureObjectParameter")]
    public class UMaterialExpressionTextureObjectParameter : UMaterialExpressionTextureSampleParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}