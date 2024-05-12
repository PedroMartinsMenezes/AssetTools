namespace AssetTool
{
    [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
    public class UStaticMeshComponent : UMeshComponent
    {
        public new const string TypeName = "StaticMeshComponent";

        public List<FStaticMeshComponentLODInfo> LODData = [];

        public new UStaticMeshComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            LODData.Resize(transfer).ForEach(x => x.Move(transfer));
            return this;
        }
    }
}
