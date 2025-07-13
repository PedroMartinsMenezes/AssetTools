namespace AssetTool
{
    [JsonAsset("PropertyHasNameFilter")]
    public class UPropertyHasNameFilter : UPropertySelectorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}