namespace AssetTool
{
    [JsonAsset("NetObjectFactory")]
    public class UNetObjectFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}