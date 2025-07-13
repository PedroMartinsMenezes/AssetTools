namespace AssetTool
{
    [JsonAsset("PropertySelectorFilter")]
    public class UPropertySelectorFilter : ULevelSnapshotBlueprintFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}