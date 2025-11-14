namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorBodyToolBuilder")]
    public class UMetaHumanCharacterEditorBodyToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterBodyModelSubToolBase")]
    public class UMetaHumanCharacterBodyModelSubToolBase : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterParametricBodyProperties")]
    public class UMetaHumanCharacterParametricBodyProperties : UMetaHumanCharacterBodyModelSubToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterFixedCompatibilityBodyProperties")]
    public class UMetaHumanCharacterFixedCompatibilityBodyProperties : UMetaHumanCharacterBodyModelSubToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyParameterProperties")]
    public class UMetaHumanCharacterEditorBodyParameterProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyModelTool")]
    public class UMetaHumanCharacterEditorBodyModelTool : UMetaHumanCharacterEditorToolWithSubTools
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BodyStateChangeTransactor")]
    public class UBodyStateChangeTransactor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyBlendToolProperties")]
    public class UMetaHumanCharacterEditorBodyBlendToolProperties : UMetaHumanCharacterEditorMeshBlendToolProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyBlendTool")]
    public class UMetaHumanCharacterEditorBodyBlendTool : UMetaHumanCharacterEditorMeshBlendTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}