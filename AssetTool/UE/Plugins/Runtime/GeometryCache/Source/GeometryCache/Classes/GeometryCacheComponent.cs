namespace AssetTool
{
    [JsonAsset("GeometryCacheComponent")]
    public class UGeometryCacheComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}