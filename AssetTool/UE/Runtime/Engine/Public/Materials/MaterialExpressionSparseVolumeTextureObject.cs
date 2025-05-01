namespace AssetTool
{
    [JsonAsset("MaterialExpressionSparseVolumeTextureObject")]
    public class UMaterialExpressionSparseVolumeTextureObject : UMaterialExpressionSparseVolumeTextureBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionSparseVolumeTextureObjectParameter")]
    public class UMaterialExpressionSparseVolumeTextureObjectParameter : UMaterialExpressionSparseVolumeTextureSampleParameter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}