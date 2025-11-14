namespace AssetTool
{
    [JsonAsset("PCGProceduralISMComponent")]
    public class UPCGProceduralISMComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGManagedProceduralISMComponent")]
    public class UPCGManagedProceduralISMComponent : UPCGManagedComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}