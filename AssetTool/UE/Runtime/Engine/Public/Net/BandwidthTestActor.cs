namespace AssetTool
{
    [JsonAsset("BandwidthTestActor")]
    public class ABandwidthTestActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}