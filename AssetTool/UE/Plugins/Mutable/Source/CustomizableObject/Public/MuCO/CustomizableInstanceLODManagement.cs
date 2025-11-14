namespace AssetTool
{
    [JsonAsset("CustomizableInstanceLODManagementBase")]
    public class UCustomizableInstanceLODManagementBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableInstanceLODManagement")]
    public class UCustomizableInstanceLODManagement : UCustomizableInstanceLODManagementBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}