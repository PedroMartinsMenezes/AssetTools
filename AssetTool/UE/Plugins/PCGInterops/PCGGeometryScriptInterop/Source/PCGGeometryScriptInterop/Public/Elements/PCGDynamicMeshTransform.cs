namespace AssetTool
{
    [JsonAsset("PCGDynamicMeshTransformSettings")]
    public class UPCGDynamicMeshTransformSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}