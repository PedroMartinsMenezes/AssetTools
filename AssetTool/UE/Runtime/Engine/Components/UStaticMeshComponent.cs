namespace AssetTool
{
    [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UStaticMeshComponent : UMeshComponent
    {
        public new const string TypeName = "StaticMeshComponent";

        public List<FStaticMeshComponentLODInfo> LODData = [];

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            LODData.Resize(transfer).ForEach(x => x.Move(transfer));
            return this;
        }
    }
}
