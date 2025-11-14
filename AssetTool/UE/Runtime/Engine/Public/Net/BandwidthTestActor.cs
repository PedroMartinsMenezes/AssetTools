namespace AssetTool
{
    [JsonAsset("BandwidthTestActor")]
    public class ABandwidthTestActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}