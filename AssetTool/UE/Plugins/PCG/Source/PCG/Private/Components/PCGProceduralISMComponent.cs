namespace AssetTool
{
    [JsonAsset("PCGProceduralISMComponent")]
    public class UPCGProceduralISMComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedProceduralISMComponent")]
    public class UPCGManagedProceduralISMComponent : UPCGManagedComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}