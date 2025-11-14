namespace AssetTool
{
    [JsonAsset("DynamicMeshActor")]
    public class ADynamicMeshActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}