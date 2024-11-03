namespace AssetTool
{
    [JsonAsset("StaticMeshComponent")]
    public class UStaticMeshComponent : UMeshComponent
    {
        public List<FStaticMeshComponentLODInfo> LODData;

        [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref LODData);
            return this;
        }
    }
}