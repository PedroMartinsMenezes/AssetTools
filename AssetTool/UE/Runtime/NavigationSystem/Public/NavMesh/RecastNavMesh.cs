namespace AssetTool
{
    [JsonAsset("RecastNavMesh")]
    public class ARecastNavMesh : ANavigationData
    {
        public uint32 NavMeshVersion;
        public uint32 RecastNavMeshSizeBytes;
        public byte[] Pad;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref NavMeshVersion);
            transfer.Move(ref RecastNavMeshSizeBytes);
            transfer.Move(ref Pad, (int)(RecastNavMeshSizeBytes - 4));

            return this;
        }
    }

    public class FDetourTileSizeInfo
    {
        public ushort VertCount;
        public ushort PolyCount;
        public ushort MaxLinkCount;
        public ushort DetailMeshCount;
        public ushort DetailVertCount;
        public ushort DetailTriCount;
        public ushort BvNodeCount;
        public ushort OffMeshConCount;
        public ushort OffMeshSegConCount;
        public ushort ClusterCount;
        public dtMeshHeader Header;

        [Location("void FPImplRecastNavMesh::SerializeRecastMeshTile(FArchive& Ar, int32 NavMeshVersion, unsigned char*& TileData, int32& TileDataSize)")]
        public void SerializeRecastMeshTile(Transfer transfer)
        {
            transfer.Move(ref VertCount);
            transfer.Move(ref PolyCount);
            transfer.Move(ref MaxLinkCount);
            transfer.Move(ref DetailMeshCount);
            transfer.Move(ref DetailVertCount);
            transfer.Move(ref DetailTriCount);
            transfer.Move(ref BvNodeCount);
            transfer.Move(ref OffMeshConCount);
            transfer.Move(ref OffMeshSegConCount);
            transfer.Move(ref ClusterCount);
            transfer.Move(ref Header);
        }
    }
}