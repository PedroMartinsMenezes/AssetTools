namespace AssetTool
{
    [JsonAsset("ReplicationDriver")]
    public class UReplicationDriver : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicationConnectionDriver")]
    public class UReplicationConnectionDriver : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}