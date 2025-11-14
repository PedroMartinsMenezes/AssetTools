namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorPresetsToolBuilder")]
    public class UMetaHumanCharacterEditorPresetsToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorPresetsToolProperties")]
    public class UMetaHumanCharacterEditorPresetsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorPresetsTool")]
    public class UMetaHumanCharacterEditorPresetsTool : USingleSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}