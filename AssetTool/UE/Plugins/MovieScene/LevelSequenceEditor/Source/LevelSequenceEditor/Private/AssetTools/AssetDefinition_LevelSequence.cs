namespace AssetTool
{
    [JsonAsset("AssetDefinition_LevelSequence")]
    public class UAssetDefinition_LevelSequence : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}