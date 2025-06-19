namespace AssetTool
{
    [JsonAsset("MaterialExpressionSparseVolumeTextureObject")]
    public class UMaterialExpressionSparseVolumeTextureObject : UMaterialExpressionSparseVolumeTextureBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionSparseVolumeTextureObjectParameter")]
    public class UMaterialExpressionSparseVolumeTextureObjectParameter : UMaterialExpressionSparseVolumeTextureSampleParameter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}