namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorHeadModelToolBuilder")]
    public class UMetaHumanCharacterEditorHeadModelToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterHeadModelSubToolBase")]
    public class UMetaHumanCharacterHeadModelSubToolBase : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterHeadModelEyelashesProperties")]
    public class UMetaHumanCharacterHeadModelEyelashesProperties : UMetaHumanCharacterHeadModelSubToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterHeadModelTeethProperties")]
    public class UMetaHumanCharacterHeadModelTeethProperties : UMetaHumanCharacterHeadModelSubToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorHeadModelTool")]
    public class UMetaHumanCharacterEditorHeadModelTool : UMetaHumanCharacterEditorToolWithSubTools
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorHeadMaterialsTool")]
    public class UMetaHumanCharacterEditorHeadMaterialsTool : UMetaHumanCharacterEditorHeadModelTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}