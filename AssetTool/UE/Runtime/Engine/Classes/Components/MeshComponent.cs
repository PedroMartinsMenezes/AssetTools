namespace AssetTool
{
    [JsonAsset("MeshComponent")]
    public class UMeshComponent : UPrimitiveComponent
    {
        [Location("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}