namespace AssetTool
{
    [JsonAsset("ReplicationStreamObject")]
    public class UReplicationStreamObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}