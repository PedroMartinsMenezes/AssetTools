namespace AssetTool
{
    [JsonAsset("PCGDynamicMeshTransformSettings")]
    public class UPCGDynamicMeshTransformSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}