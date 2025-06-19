namespace AssetTool
{
    [JsonAsset("AvaTestStaticMeshActor")]
    public class AAvaTestStaticMeshActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}