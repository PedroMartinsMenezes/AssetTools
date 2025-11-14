
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
            transfer.Move(ref Tiles);
        }
    }

    public class FRecastTileData : ITransferable
    {
        public int32 TileDataSize;
        public FDetourTileSizeInfo DetourTileSizeInfo = new();
        public dtTileCacheLayerHeader Header = new();

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref TileDataSize);
            DetourTileSizeInfo.SerializeRecastMeshTile(transfer);
            Header.SerializeCompressedTileCacheData(transfer);
            return this;
        }
    }
}