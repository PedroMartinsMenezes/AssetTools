namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorFaceEditingToolBuilder")]
    public class UMetaHumanCharacterEditorFaceEditingToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FaceStateChangeTransactor")]
    public class UFaceStateChangeTransactor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorFaceMoveToolProperties")]
    public class UMetaHumanCharacterEditorFaceMoveToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorFaceMoveTool")]
    public class UMetaHumanCharacterEditorFaceMoveTool : UMetaHumanCharacterEditorFaceTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorFaceSculptTool")]
    public class UMetaHumanCharacterEditorFaceSculptTool : UMetaHumanCharacterEditorFaceTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorFaceBlendToolProperties")]
    public class UMetaHumanCharacterEditorFaceBlendToolProperties : UMetaHumanCharacterEditorMeshBlendToolProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorFaceBlendTool")]
    public class UMetaHumanCharacterEditorFaceBlendTool : UMetaHumanCharacterEditorMeshBlendTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}