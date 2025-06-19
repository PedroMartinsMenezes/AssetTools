namespace AssetTool
{
    [JsonAsset("StaticMeshActor")]
    public class AStaticMeshActor : AActor
    {
        [Location("void AStaticMeshActor::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
