namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorSkinToolBuilder")]
    public class UMetaHumanCharacterEditorSkinToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorSkinToolProperties")]
    public class UMetaHumanCharacterEditorSkinToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorSkinTool")]
    public class UMetaHumanCharacterEditorSkinTool : USingleSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}