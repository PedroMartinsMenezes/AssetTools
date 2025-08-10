namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorBodyConformToolBuilder")]
    public class UMetaHumanCharacterEditorBodyConformToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterImportBodyDNAProperties")]
    public class UMetaHumanCharacterImportBodyDNAProperties : UMetaHumanCharacterImportSubToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterImportBodyTemplateProperties")]
    public class UMetaHumanCharacterImportBodyTemplateProperties : UMetaHumanCharacterImportSubToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorBodyConformTool")]
    public class UMetaHumanCharacterEditorBodyConformTool : UMetaHumanCharacterEditorToolWithSubTools
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}