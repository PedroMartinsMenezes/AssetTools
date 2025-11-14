namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorConformToolBuilder")]
    public class UMetaHumanCharacterEditorConformToolBuilder : UMetaHumanCharacterEditorToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterImportSubToolBase")]
    public class UMetaHumanCharacterImportSubToolBase : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterImportDNAProperties")]
    public class UMetaHumanCharacterImportDNAProperties : UMetaHumanCharacterImportSubToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterImportIdentityProperties")]
    public class UMetaHumanCharacterImportIdentityProperties : UMetaHumanCharacterImportSubToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterImportTemplateProperties")]
    public class UMetaHumanCharacterImportTemplateProperties : UMetaHumanCharacterImportSubToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacterEditorConformTool")]
    public class UMetaHumanCharacterEditorConformTool : UMetaHumanCharacterEditorToolWithSubTools
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}