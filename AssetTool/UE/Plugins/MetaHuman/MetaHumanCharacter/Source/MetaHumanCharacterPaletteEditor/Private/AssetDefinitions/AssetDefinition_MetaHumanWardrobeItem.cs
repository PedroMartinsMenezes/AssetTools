namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaHumanWardrobeItem")]
    public class UAssetDefinition_MetaHumanWardrobeItem : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}