namespace AssetTool
{
    [JsonAsset("DynamicMeshActor")]
    public class ADynamicMeshActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}