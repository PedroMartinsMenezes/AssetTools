namespace AssetTool
{
    [JsonAsset("MaterialExpressionSparseVolumeTextureSample")]
    public class UMaterialExpressionSparseVolumeTextureSample : UMaterialExpressionSparseVolumeTextureBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionSparseVolumeTextureSampleParameter")]
    public class UMaterialExpressionSparseVolumeTextureSampleParameter : UMaterialExpressionSparseVolumeTextureSample
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}