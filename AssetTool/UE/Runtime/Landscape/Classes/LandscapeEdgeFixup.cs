namespace AssetTool
{
    [JsonAsset("LandscapeHeightmapTextureEdgeFixup")]
    public class ULandscapeHeightmapTextureEdgeFixup : UObject
    {
        public FHeightmapTextureEdgeSnapshot NewEdgeSnapshot;

        [Location("void ULandscapeHeightmapTextureEdgeFixup::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref NewEdgeSnapshot);
            return this;
        }
    }

    public class FHeightmapTextureEdgeSnapshot : ITransferable
    {
        public int32 EdgeLength;
        public uint32[] EdgeData;
        public uint32[] CornerData;
        public uint32[] SnapshotEdgeHashes;
        public FGuid TextureSourceID;
        public uint32[] InitialEdgeHashes;

        [Location("FArchive& operator<<(FArchive& Ar, FHeightmapTextureEdgeSnapshot& EdgeSnapshot)")]
        public ITransferable Move(Transfer transfer)
        {
            int32 BeforeCornerDataWasRemoved = (int32)FHeightmapTextureEdgeSnapshotCustomVersion.Enums.BeforeCornerDataWasRemoved;
            int32 BeforeInitialHashWasAdded = (int32)FHeightmapTextureEdgeSnapshotCustomVersion.Enums.BeforeInitialHashWasAdded;

            transfer.Move(ref EdgeLength);
            transfer.Move(ref EdgeData);

            if (transfer.GlobalObjects.CustomVer(FHeightmapTextureEdgeSnapshotCustomVersion.Guid) <= BeforeCornerDataWasRemoved)
            {
                transfer.Move(ref CornerData, 4);
            }
            transfer.Move(ref SnapshotEdgeHashes, 8);
            if (transfer.GlobalObjects.CustomVer(FHeightmapTextureEdgeSnapshotCustomVersion.Guid) > BeforeCornerDataWasRemoved)
            {
                transfer.Move(ref TextureSourceID);
            }
            if (transfer.GlobalObjects.CustomVer(FHeightmapTextureEdgeSnapshotCustomVersion.Guid) > BeforeInitialHashWasAdded)
            {
                transfer.Move(ref InitialEdgeHashes, 8);
            }
            return this;
        }
    }
}