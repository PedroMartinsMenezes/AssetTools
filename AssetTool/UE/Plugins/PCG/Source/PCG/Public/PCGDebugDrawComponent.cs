namespace AssetTool
{
    [JsonAsset("PCGManagedDebugDrawComponent")]
    public class UPCGManagedDebugDrawComponent : UPCGManagedComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDebugDrawComponent")]
    public class UPCGDebugDrawComponent : UDebugDrawComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}