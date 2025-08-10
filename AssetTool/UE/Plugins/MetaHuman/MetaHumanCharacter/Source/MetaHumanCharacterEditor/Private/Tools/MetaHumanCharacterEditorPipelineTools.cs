namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorPipelineToolBuilder")]
    public class UMetaHumanCharacterEditorPipelineToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorPipelineToolProperties")]
    public class UMetaHumanCharacterEditorPipelineToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorPipelineTool")]
    public class UMetaHumanCharacterEditorPipelineTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}