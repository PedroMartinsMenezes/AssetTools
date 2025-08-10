namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorBodyToolBuilder")]
    public class UMetaHumanCharacterEditorBodyToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterBodyModelSubToolBase")]
    public class UMetaHumanCharacterBodyModelSubToolBase : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterParametricBodyProperties")]
    public class UMetaHumanCharacterParametricBodyProperties : UMetaHumanCharacterBodyModelSubToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterFixedCompatibilityBodyProperties")]
    public class UMetaHumanCharacterFixedCompatibilityBodyProperties : UMetaHumanCharacterBodyModelSubToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyParameterProperties")]
    public class UMetaHumanCharacterEditorBodyParameterProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyModelTool")]
    public class UMetaHumanCharacterEditorBodyModelTool : UMetaHumanCharacterEditorToolWithSubTools
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BodyStateChangeTransactor")]
    public class UBodyStateChangeTransactor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyBlendToolProperties")]
    public class UMetaHumanCharacterEditorBodyBlendToolProperties : UMetaHumanCharacterEditorMeshBlendToolProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyBlendTool")]
    public class UMetaHumanCharacterEditorBodyBlendTool : UMetaHumanCharacterEditorMeshBlendTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}