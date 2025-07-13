namespace AssetTool
{
    [JsonAsset("ReplicationSystem")]
    public class UReplicationSystem : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}