namespace AssetTool
{
    [JsonAsset("ChaosVDDataContainerBaseActor")]
    public class AChaosVDDataContainerBaseActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}