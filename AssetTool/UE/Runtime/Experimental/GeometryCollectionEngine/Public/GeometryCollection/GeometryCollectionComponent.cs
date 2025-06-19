namespace AssetTool
{
    [JsonAsset("GeometryCollectionComponent")]
    public class UGeometryCollectionComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}