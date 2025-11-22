namespace AssetTool
{
    [JsonAsset("DynamicMesh")]
    public class UDynamicMesh : UObject
    {
        public Geometry.FDynamicMesh3 Mesh;

        [Location("void UDynamicMesh::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Mesh);
            return this;
        }
    }
}