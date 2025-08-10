namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorMakeupToolBuilder")]
    public class UMetaHumanCharacterEditorMakeupToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorMakeupToolProperties")]
    public class UMetaHumanCharacterEditorMakeupToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorMakeupTool")]
    public class UMetaHumanCharacterEditorMakeupTool : USingleSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}