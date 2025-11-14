namespace AssetTool
{
    [JsonAsset("ReplicationStateDescriptorConfig")]
    public class UReplicationStateDescriptorConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}