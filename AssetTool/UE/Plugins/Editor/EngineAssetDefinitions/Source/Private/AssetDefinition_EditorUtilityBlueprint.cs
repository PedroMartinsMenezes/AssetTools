namespace AssetTool
{
    [JsonAsset("AssetDefinition_EditorUtilityBlueprint")]
    public class UAssetDefinition_EditorUtilityBlueprint : UAssetDefinition_Blueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}