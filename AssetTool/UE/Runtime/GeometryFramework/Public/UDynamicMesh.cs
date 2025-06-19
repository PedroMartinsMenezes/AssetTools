namespace AssetTool
{
    [JsonAsset("DynamicMeshGenerator")]
    public class UDynamicMeshGenerator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicMesh")]
    public class UDynamicMesh : UObject
    {
        public Geometry.FDynamicMesh3 Mesh;

        [Location("void UDynamicMesh::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Mesh);
            return this;
        }
    }

    [JsonAsset("DynamicMeshPool")]
    public class UDynamicMeshPool : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}