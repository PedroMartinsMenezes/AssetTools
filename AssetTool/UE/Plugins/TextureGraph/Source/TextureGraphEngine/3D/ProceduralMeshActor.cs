namespace AssetTool
{
    [JsonAsset("ProceduralMeshActor")]
    public class AProceduralMeshActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}