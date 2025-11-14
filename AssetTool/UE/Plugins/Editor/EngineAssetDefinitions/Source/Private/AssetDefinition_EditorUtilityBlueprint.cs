namespace AssetTool
{
    [JsonAsset("AssetDefinition_EditorUtilityBlueprint")]
    public class UAssetDefinition_EditorUtilityBlueprint : UAssetDefinition_Blueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}