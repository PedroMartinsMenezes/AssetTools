namespace AssetTool
{
    [JsonAsset("TestReplicatedActor")]
    public class ATestReplicatedActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}