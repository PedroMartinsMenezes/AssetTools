namespace AssetTool
{
    [JsonAsset("PCGBooleanOperationSettings")]
    public class UPCGBooleanOperationSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}