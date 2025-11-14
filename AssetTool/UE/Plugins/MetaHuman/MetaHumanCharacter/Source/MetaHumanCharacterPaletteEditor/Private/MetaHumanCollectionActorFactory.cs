namespace AssetTool
{
    [JsonAsset("MetaHumanCollectionActorFactory")]
    public class UMetaHumanCollectionActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}