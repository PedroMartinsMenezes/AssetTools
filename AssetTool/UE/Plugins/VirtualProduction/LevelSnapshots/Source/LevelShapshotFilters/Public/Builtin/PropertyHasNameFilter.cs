namespace AssetTool
{
    [JsonAsset("PropertyHasNameFilter")]
    public class UPropertyHasNameFilter : UPropertySelectorFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}