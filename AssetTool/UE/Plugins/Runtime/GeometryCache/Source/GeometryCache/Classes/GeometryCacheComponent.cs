namespace AssetTool
{
    [JsonAsset("GeometryCacheComponent")]
    public class UGeometryCacheComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}