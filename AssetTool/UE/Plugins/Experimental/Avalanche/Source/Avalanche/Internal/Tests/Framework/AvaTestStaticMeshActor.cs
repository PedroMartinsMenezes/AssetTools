namespace AssetTool
{
    [JsonAsset("AvaTestStaticMeshActor")]
    public class AAvaTestStaticMeshActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}