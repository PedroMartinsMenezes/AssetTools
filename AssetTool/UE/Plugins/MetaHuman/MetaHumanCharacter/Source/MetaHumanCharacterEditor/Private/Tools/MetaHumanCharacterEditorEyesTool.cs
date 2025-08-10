namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEyePresets")]
    public class UMetaHumanCharacterEyePresets : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorEyesToolBuilder")]
    public class UMetaHumanCharacterEditorEyesToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorEyesToolProperties")]
    public class UMetaHumanCharacterEditorEyesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorEyesTool")]
    public class UMetaHumanCharacterEditorEyesTool : USingleSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}