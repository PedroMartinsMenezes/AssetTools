namespace AssetTool
{
    [JsonAsset("ProceduralMeshActor")]
    public class AProceduralMeshActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}