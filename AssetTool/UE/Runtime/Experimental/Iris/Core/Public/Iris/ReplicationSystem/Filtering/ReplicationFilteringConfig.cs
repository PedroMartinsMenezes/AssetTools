namespace AssetTool
{
    [JsonAsset("ReplicationFilteringConfig")]
    public class UReplicationFilteringConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}