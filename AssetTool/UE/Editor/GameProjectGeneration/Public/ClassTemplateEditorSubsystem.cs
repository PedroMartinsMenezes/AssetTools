namespace AssetTool
{
    [JsonAsset("ClassTemplate")]
    public class UClassTemplate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PluginClassTemplate")]
    public class UPluginClassTemplate : UClassTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClassTemplateEditorSubsystem")]
    public class UClassTemplateEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}