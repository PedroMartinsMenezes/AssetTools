namespace AssetTool
{
    [JsonAsset("GeometryCacheComponent")]
    public class UGeometryCacheComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}