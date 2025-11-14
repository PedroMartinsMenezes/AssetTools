namespace AssetTool
{
    [JsonAsset("ContentBundleEditorSubsystemModule")]
    public class UContentBundleEditorSubsystemModule : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBundleEditingSubmodule")]
    public class UContentBundleEditingSubmodule : UContentBundleEditorSubsystemModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBundleEditorSubsystem")]
    public class UContentBundleEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}