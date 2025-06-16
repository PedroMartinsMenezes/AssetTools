namespace AssetTool
{
    [JsonAsset("ClassTemplate")]
    public class UClassTemplate : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PluginClassTemplate")]
    public class UPluginClassTemplate : UClassTemplate
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClassTemplateEditorSubsystem")]
    public class UClassTemplateEditorSubsystem : UEditorSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}