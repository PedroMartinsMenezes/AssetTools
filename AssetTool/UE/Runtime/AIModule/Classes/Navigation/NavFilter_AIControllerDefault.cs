namespace AssetTool
{
    [JsonAsset("NavFilter_AIControllerDefault")]
    public class UNavFilter_AIControllerDefault : UNavigationQueryFilter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}