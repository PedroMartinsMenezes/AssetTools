namespace AssetTool
{
    [JsonAsset("PCGManagedResource")]
    public class UPCGManagedResource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedActors")]
    public class UPCGManagedActors : UPCGManagedResource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponentBase")]
    public class UPCGManagedComponentBase : UPCGManagedResource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponent")]
    public class UPCGManagedComponent : UPCGManagedComponentBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponentList")]
    public class UPCGManagedComponentList : UPCGManagedComponentBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedComponentDefaultList")]
    public class UPCGManagedComponentDefaultList : UPCGManagedComponentList
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedISMComponent")]
    public class UPCGManagedISMComponent : UPCGManagedComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedSplineMeshComponent")]
    public class UPCGManagedSplineMeshComponent : UPCGManagedComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}