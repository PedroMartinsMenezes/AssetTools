namespace AssetTool
{
    [JsonAsset("ReplicationSystem")]
    public class UReplicationSystem : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}