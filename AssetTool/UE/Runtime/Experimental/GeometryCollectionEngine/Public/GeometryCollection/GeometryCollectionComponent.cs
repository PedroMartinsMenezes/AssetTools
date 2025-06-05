namespace AssetTool
{
    [JsonAsset("GeometryCollectionComponent")]
    public class UGeometryCollectionComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}