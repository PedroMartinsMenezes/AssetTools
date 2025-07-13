namespace AssetTool
{
    [JsonAsset("PCGStaticMeshToDynamicMeshSettings")]
    public class UPCGStaticMeshToDynamicMeshSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}