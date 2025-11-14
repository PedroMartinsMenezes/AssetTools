namespace AssetTool
{
    [JsonAsset("ReplicatedTestObjectFactory")]
    public class UReplicatedTestObjectFactory : UNetObjectFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}