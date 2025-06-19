namespace AssetTool
{
    [JsonAsset("DataprepStringObjectNameFetcher")]
    public class UDataprepStringObjectNameFetcher : UDataprepStringFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepStringActorLabelFetcher")]
    public class UDataprepStringActorLabelFetcher : UDataprepStringFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}