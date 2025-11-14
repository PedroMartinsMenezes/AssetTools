namespace AssetTool
{
    [JsonAsset("PCGDynamicMeshManagedComponent")]
    public class UPCGDynamicMeshManagedComponent : UPCGManagedComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}