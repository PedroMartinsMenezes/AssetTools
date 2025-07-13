namespace AssetTool
{
    [JsonAsset("PCGDynamicMeshManagedComponent")]
    public class UPCGDynamicMeshManagedComponent : UPCGManagedComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}