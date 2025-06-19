namespace AssetTool
{
    [JsonAsset("SplineMeshComponent")]
    public class USplineMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}