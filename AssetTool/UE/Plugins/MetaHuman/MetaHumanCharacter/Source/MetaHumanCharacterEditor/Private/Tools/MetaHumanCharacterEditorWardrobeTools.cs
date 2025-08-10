namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorWardrobeToolBuilder")]
    public class UMetaHumanCharacterEditorWardrobeToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorWardrobeToolProperties")]
    public class UMetaHumanCharacterEditorWardrobeToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorWardrobeTool")]
    public class UMetaHumanCharacterEditorWardrobeTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}