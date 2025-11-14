namespace AssetTool
{
    [JsonAsset("MeshComponent")]
    public class UMeshComponent : UPrimitiveComponent
    {
        [Location("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}