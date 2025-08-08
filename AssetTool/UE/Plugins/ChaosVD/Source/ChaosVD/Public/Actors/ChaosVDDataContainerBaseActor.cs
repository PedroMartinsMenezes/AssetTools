namespace AssetTool
{
    [JsonAsset("ChaosVDDataContainerBaseActor")]
    public class AChaosVDDataContainerBaseActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}