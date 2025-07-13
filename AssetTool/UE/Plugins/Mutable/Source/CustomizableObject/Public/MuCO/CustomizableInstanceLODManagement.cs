namespace AssetTool
{
    [JsonAsset("CustomizableInstanceLODManagementBase")]
    public class UCustomizableInstanceLODManagementBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableInstanceLODManagement")]
    public class UCustomizableInstanceLODManagement : UCustomizableInstanceLODManagementBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}