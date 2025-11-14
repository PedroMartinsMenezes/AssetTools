namespace AssetTool
{
    [JsonAsset("ClassTemplate")]
    public class UClassTemplate : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PluginClassTemplate")]
    public class UPluginClassTemplate : UClassTemplate
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClassTemplateEditorSubsystem")]
    public class UClassTemplateEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}