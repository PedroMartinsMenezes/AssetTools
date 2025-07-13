namespace AssetTool
{
    [JsonAsset("NetSubObjectFactory")]
    public class UNetSubObjectFactory : UNetObjectFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}