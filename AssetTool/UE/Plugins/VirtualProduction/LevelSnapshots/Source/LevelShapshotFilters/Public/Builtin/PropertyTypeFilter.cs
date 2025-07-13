namespace AssetTool
{
    [JsonAsset("PropertyTypeFilter")]
    public class UPropertyTypeFilter : UPropertySelectorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}