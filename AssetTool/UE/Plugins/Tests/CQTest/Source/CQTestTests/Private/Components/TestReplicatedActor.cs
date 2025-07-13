namespace AssetTool
{
    [JsonAsset("TestReplicatedActor")]
    public class ATestReplicatedActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}