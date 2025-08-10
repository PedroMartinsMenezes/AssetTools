namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaHumanCharacter")]
    public class UAssetDefinition_MetaHumanCharacter : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}