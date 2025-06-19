namespace AssetTool
{
    [JsonAsset("AvaTestDynamicMeshActor")]
    public class AAvaTestDynamicMeshActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}