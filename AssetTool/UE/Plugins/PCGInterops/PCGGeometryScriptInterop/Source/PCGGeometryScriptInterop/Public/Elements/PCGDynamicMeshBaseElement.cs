namespace AssetTool
{
    [JsonAsset("PCGDynamicMeshBaseSettings")]
    public class UPCGDynamicMeshBaseSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}