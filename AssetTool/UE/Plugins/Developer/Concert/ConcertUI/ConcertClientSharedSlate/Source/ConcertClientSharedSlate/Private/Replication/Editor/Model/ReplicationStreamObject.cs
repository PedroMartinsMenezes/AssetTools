namespace AssetTool
{
    [JsonAsset("ReplicationStreamObject")]
    public class UReplicationStreamObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}