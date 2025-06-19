namespace AssetTool
{
    [JsonAsset("MaterialExpressionSparseVolumeTextureSample")]
    public class UMaterialExpressionSparseVolumeTextureSample : UMaterialExpressionSparseVolumeTextureBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionSparseVolumeTextureSampleParameter")]
    public class UMaterialExpressionSparseVolumeTextureSampleParameter : UMaterialExpressionSparseVolumeTextureSample
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}