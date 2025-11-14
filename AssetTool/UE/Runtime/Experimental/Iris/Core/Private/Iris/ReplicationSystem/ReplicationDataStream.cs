namespace AssetTool
{
    [JsonAsset("ReplicationDataStream")]
    public class UReplicationDataStream : UDataStream
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}