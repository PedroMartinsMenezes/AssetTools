namespace AssetTool
{
    [JsonAsset("NetActorFactory")]
    public class UNetActorFactory : UNetObjectFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}