namespace AssetTool
{
    [JsonAsset("PCGProceduralISMComponent")]
    public class UPCGProceduralISMComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedProceduralISMComponent")]
    public class UPCGManagedProceduralISMComponent : UPCGManagedComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}