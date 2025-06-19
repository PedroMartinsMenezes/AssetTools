namespace AssetTool
{
    [JsonAsset("SplineMeshActor")]
    public class ASplineMeshActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}