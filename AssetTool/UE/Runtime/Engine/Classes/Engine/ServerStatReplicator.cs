namespace AssetTool
{
    [JsonAsset("ServerStatReplicator")]
    public class AServerStatReplicator : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}