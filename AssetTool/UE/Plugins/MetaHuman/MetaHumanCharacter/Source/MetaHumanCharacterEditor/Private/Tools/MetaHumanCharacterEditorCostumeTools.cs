namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorCostumeToolBuilder")]
    public class UMetaHumanCharacterEditorCostumeToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorCostumeToolProperties")]
    public class UMetaHumanCharacterEditorCostumeToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorCostumeTool")]
    public class UMetaHumanCharacterEditorCostumeTool : USingleTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}