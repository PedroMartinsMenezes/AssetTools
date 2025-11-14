namespace AssetTool
{
    [JsonAsset("PropertySelectorFilter")]
    public class UPropertySelectorFilter : ULevelSnapshotBlueprintFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}