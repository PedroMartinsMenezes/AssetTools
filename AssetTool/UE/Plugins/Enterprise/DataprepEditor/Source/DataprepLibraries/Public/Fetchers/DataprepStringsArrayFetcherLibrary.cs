namespace AssetTool
{
    [JsonAsset("DataprepStringActorTagsFetcher")]
    public class UDataprepStringActorTagsFetcher : UDataprepStringsArrayFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepStringActorLayersFetcher")]
    public class UDataprepStringActorLayersFetcher : UDataprepStringsArrayFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}