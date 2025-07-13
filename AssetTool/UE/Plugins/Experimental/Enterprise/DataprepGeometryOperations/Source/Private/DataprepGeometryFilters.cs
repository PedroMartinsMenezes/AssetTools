namespace AssetTool
{
    [JsonAsset("DataprepJacketingFilter")]
    public class UDataprepJacketingFilter : UDataprepFilterNoFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}