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

    [JsonAsset("PCGManagedComponentBase")]
    public class UPCGManagedComponentBase : UPCGManagedResource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponent")]
    public class UPCGManagedComponent : UPCGManagedComponentBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponentList")]
    public class UPCGManagedComponentList : UPCGManagedComponentBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponentDefaultList")]
    public class UPCGManagedComponentDefaultList : UPCGManagedComponentList
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

    [JsonAsset("PCGManagedSplineMeshComponent")]
    public class UPCGManagedSplineMeshComponent : UPCGManagedComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}