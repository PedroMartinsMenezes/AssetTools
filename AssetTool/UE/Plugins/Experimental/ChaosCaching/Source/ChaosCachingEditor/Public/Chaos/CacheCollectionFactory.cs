namespace AssetTool
{
    [JsonAsset("CacheCollectionFactory")]
    public class UCacheCollectionFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}