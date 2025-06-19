namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureCollectionParameter")]
    public class UMaterialExpressionTextureCollectionParameter : UMaterialExpressionTextureCollection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}