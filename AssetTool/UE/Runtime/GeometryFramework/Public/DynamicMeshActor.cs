namespace AssetTool
{
    [JsonAsset("DynamicMeshActor")]
    public class ADynamicMeshActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}