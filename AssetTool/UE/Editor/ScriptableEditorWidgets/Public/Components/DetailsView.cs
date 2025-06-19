namespace AssetTool
{
    [JsonAsset("DetailsView")]
    public class UDetailsView : UPropertyViewBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}