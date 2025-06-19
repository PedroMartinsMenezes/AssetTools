namespace AssetTool
{
    [JsonAsset("ServerStatReplicator")]
    public class AServerStatReplicator : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}