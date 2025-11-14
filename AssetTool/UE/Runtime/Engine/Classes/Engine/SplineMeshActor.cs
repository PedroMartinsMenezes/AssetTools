namespace AssetTool
{
    [JsonAsset("SplineMeshActor")]
    public class ASplineMeshActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}