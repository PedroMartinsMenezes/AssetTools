namespace AssetTool
{
    [JsonAsset("StaticMeshComponent")]
    public class UStaticMeshComponent : UMeshComponent
    {
        public List<FStaticMeshComponentLODInfo> LODData = [];

        [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            LODData.Resize(transfer).ForEach(x => x.Move(transfer));
            return this;
        }
    }
}
