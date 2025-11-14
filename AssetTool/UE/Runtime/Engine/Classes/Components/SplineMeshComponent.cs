namespace AssetTool
{
    [JsonAsset("SplineMeshComponent")]
    public class USplineMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}