namespace AssetTool
{
    [JsonAsset("GeometryCollectionComponent")]
    public class UGeometryCollectionComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}