namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorMeshEditingToolProperties")]
    public class UMetaHumanCharacterEditorMeshEditingToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorMeshEditingTool")]
    public class UMetaHumanCharacterEditorMeshEditingTool : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorFaceEditingToolHeadParameterProperties")]
    public class UMetaHumanCharacterEditorFaceEditingToolHeadParameterProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorFaceTool")]
    public class UMetaHumanCharacterEditorFaceTool : UMetaHumanCharacterEditorMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorMeshBlendToolProperties")]
    public class UMetaHumanCharacterEditorMeshBlendToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorMeshBlendTool")]
    public class UMetaHumanCharacterEditorMeshBlendTool : UMetaHumanCharacterEditorFaceTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}