namespace AssetTool
{
    [JsonAsset("AssetDefinition_HierarchyTable")]
    public class UAssetDefinition_HierarchyTable : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}