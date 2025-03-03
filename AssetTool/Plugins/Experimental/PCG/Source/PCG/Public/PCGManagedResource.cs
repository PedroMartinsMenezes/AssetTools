namespace AssetTool
{
    [JsonAsset("PCGManagedResource")]
    public class UPCGManagedResource : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedActors")]
    public class UPCGManagedActors : UPCGManagedResource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponent")]
    public class UPCGManagedComponent : UPCGManagedResource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedISMComponent")]
    public class UPCGManagedISMComponent : UPCGManagedComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}