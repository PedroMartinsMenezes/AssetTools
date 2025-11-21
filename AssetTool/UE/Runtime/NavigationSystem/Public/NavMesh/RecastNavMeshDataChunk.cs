
namespace AssetTool
{
    [JsonAsset("RecastNavMeshDataChunk")]
    public class URecastNavMeshDataChunk : UNavigationDataChunk
    {
        public int32 NavMeshVersion;
        public int64 RecastNavMeshSizeBytes;
        public int32 TileNum;
        public List<FRecastTileData> Tiles;
        public byte[] NavMeshData;

        [Location("void URecastNavMeshDataChunk::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref NavMeshVersion);
            transfer.Move(ref RecastNavMeshSizeBytes);

            if (NavMeshVersion < Consts.NAVMESHVER_MIN_COMPATIBLE || NavMeshVersion > Consts.NAVMESHVER_LATEST || RecastNavMeshSizeBytes <= 4)
            {
                CleanUpBadVersion(transfer);
                return this;
            }

            SerializeRecastData(transfer, NavMeshVersion);

            return this;
        }

        private void CleanUpBadVersion(Transfer transfer)
        {
            transfer.Move(ref NavMeshData, (int)RecastNavMeshSizeBytes - 8);
        }

        [Location("void URecastNavMeshDataChunk::SerializeRecastData(FArchive& Ar, int32 NavMeshVersion)")]
        private void SerializeRecastData(Transfer transfer, int navMeshVersion)
        {
            transfer.Resize(ref Tiles);
            Tiles.ForEach(x => x.SerializeRecastMeshTile(transfer, navMeshVersion));
        }
    }

    public class FRecastTileData
    {
        public int32 TileDataSize;
        public FDetourTileSizeInfo DetourTileSizeInfo = new();
        public dtTileCacheLayerHeader Header = new();

        [Location("void FPImplRecastNavMesh::SerializeRecastMeshTile(FArchive& Ar, int32 NavMeshVersion, unsigned char*& TileData, int32& TileDataSize)")]
        public void SerializeRecastMeshTile(Transfer transfer, int32 NavMeshVersion)
        {
            transfer.Move(ref TileDataSize);

            DetourTileSizeInfo.SerializeRecastMeshTile(transfer, NavMeshVersion);

            Header.SerializeCompressedTileCacheData(transfer);
        }
    }
}