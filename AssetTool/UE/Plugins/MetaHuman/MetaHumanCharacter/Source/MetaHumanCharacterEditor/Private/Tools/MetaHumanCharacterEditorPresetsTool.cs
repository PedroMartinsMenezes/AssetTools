namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorPresetsToolBuilder")]
    public class UMetaHumanCharacterEditorPresetsToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorPresetsToolProperties")]
    public class UMetaHumanCharacterEditorPresetsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorPresetsTool")]
    public class UMetaHumanCharacterEditorPresetsTool : USingleSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}