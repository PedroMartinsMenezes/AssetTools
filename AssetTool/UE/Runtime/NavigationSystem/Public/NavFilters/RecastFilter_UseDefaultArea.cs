namespace AssetTool
{
    [JsonAsset("RecastFilter_UseDefaultArea")]
    public class URecastFilter_UseDefaultArea : UNavigationQueryFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}