namespace AssetTool
{
    [JsonAsset("HierarchyTableOverrideFactory")]
    public class UHierarchyTableOverrideFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}