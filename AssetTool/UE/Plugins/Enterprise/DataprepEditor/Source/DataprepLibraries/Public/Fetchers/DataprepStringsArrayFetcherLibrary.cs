namespace AssetTool
{
    [JsonAsset("DataprepStringActorTagsFetcher")]
    public class UDataprepStringActorTagsFetcher : UDataprepStringsArrayFetcher
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepStringActorLayersFetcher")]
    public class UDataprepStringActorLayersFetcher : UDataprepStringsArrayFetcher
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}