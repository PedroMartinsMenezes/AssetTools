namespace AssetTool
{
    [JsonAsset("NetActorFactory")]
    public class UNetActorFactory : UNetObjectFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}