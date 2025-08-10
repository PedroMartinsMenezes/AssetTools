namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorHeadModelToolBuilder")]
    public class UMetaHumanCharacterEditorHeadModelToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterHeadModelSubToolBase")]
    public class UMetaHumanCharacterHeadModelSubToolBase : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterHeadModelEyelashesProperties")]
    public class UMetaHumanCharacterHeadModelEyelashesProperties : UMetaHumanCharacterHeadModelSubToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterHeadModelTeethProperties")]
    public class UMetaHumanCharacterHeadModelTeethProperties : UMetaHumanCharacterHeadModelSubToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorHeadModelTool")]
    public class UMetaHumanCharacterEditorHeadModelTool : UMetaHumanCharacterEditorToolWithSubTools
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorHeadMaterialsTool")]
    public class UMetaHumanCharacterEditorHeadMaterialsTool : UMetaHumanCharacterEditorHeadModelTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}