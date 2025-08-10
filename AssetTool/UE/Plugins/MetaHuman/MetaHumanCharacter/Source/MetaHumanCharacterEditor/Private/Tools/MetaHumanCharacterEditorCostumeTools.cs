namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorCostumeToolBuilder")]
    public class UMetaHumanCharacterEditorCostumeToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorCostumeToolProperties")]
    public class UMetaHumanCharacterEditorCostumeToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorCostumeTool")]
    public class UMetaHumanCharacterEditorCostumeTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}