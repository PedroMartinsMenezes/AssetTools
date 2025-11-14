namespace AssetTool
{
    [JsonAsset("HierarchyTableOverrideFactory")]
    public class UHierarchyTableOverrideFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}