namespace AssetTool
{
    [JsonAsset("SplineMeshComponent")]
    public class USplineMeshComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}