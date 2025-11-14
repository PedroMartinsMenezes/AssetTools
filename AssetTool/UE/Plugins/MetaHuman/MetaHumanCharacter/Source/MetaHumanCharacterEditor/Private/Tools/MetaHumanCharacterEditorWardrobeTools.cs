namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorWardrobeToolBuilder")]
    public class UMetaHumanCharacterEditorWardrobeToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorWardrobeToolProperties")]
    public class UMetaHumanCharacterEditorWardrobeToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorWardrobeTool")]
    public class UMetaHumanCharacterEditorWardrobeTool : USingleTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}