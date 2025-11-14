namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorSubToolsProperties")]
    public class UMetaHumanCharacterEditorSubToolsProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorToolWithSubTools")]
    public class UMetaHumanCharacterEditorToolWithSubTools : USingleSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorToolWithToolTargetsBuilder")]
    public class UMetaHumanCharacterEditorToolWithToolTargetsBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}