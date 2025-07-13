namespace AssetTool
{
    [JsonAsset("ObjectReplicationBridgeConfig")]
    public class UObjectReplicationBridgeConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}