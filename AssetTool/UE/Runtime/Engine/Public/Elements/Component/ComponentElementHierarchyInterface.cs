namespace AssetTool
{
    [JsonAsset("ComponentElementHierarchyInterface")]
    public class UComponentElementHierarchyInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}