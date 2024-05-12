namespace AssetTool
{
    [Location("void UStaticMesh::Serialize(FArchive& Ar)")]
    public class UStaticMesh : UStreamableRenderAsset
    {
        public const string TypeName = "StaticMesh";

        public new UStaticMesh Move(Transfer transfer) => (UStaticMesh)base.Move(transfer);
    }
}
