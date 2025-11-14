namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureCollectionParameter")]
    public class UMaterialExpressionTextureCollectionParameter : UMaterialExpressionTextureCollection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}