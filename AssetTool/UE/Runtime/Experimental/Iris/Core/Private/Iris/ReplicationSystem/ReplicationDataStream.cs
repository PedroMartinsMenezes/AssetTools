namespace AssetTool
{
    [JsonAsset("ReplicationDataStream")]
    public class UReplicationDataStream : UDataStream
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}