namespace AssetTool
{
    [JsonAsset("PropertyTypeFilter")]
    public class UPropertyTypeFilter : UPropertySelectorFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}