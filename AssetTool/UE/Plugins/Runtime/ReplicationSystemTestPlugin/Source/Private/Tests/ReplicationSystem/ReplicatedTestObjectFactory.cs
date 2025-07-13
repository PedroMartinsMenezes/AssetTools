namespace AssetTool
{
    [JsonAsset("ReplicatedTestObjectFactory")]
    public class UReplicatedTestObjectFactory : UNetObjectFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}