namespace AssetTool
{
    [JsonAsset("ContentBundleEditorSubsystemModule")]
    public class UContentBundleEditorSubsystemModule : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBundleEditingSubmodule")]
    public class UContentBundleEditingSubmodule : UContentBundleEditorSubsystemModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBundleEditorSubsystem")]
    public class UContentBundleEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}