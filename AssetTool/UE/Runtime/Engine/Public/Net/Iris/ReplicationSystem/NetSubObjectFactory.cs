namespace AssetTool
{
    [JsonAsset("NetSubObjectFactory")]
    public class UNetSubObjectFactory : UNetObjectFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}