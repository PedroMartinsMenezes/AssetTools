namespace AssetTool
{
    [JsonAsset("MetaHumanCollectionActorFactory")]
    public class UMetaHumanCollectionActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}