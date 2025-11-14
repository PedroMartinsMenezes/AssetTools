namespace AssetTool
{
    [JsonAsset("ObjectReplicationBridge")]
    public class UObjectReplicationBridge : UReplicationBridge
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}