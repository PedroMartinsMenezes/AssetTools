namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaHumanCharacterInstance")]
    public class UAssetDefinition_MetaHumanCharacterInstance : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}