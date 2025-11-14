namespace AssetTool
{
    [JsonAsset("ObjectReplicationBridgeConfig")]
    public class UObjectReplicationBridgeConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}