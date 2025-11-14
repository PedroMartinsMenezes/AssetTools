namespace AssetTool
{
    [JsonAsset("AvaTestDynamicMeshActor")]
    public class AAvaTestDynamicMeshActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}