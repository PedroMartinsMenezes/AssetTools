namespace AssetTool
{
    [JsonAsset("ComponentElementHierarchyInterface")]
    public class UComponentElementHierarchyInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}