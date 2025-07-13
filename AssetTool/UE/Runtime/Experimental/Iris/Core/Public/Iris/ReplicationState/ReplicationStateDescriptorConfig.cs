namespace AssetTool
{
    [JsonAsset("ReplicationStateDescriptorConfig")]
    public class UReplicationStateDescriptorConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}