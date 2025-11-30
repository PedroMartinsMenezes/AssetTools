namespace AssetTool.Nanite
{
    public class FResources : ITransferable
    {
        public FStripDataFlags StripFlags;
        public uint32 ResourceFlags;
        public List<uint8> RootData;
        public List<FPageStreamingState> PageStreamingStates;
        public List<FPackedHierarchyNode> HierarchyNodes;
        public List<uint32> HierarchyRootOffsets;
        public List<uint32> PageDependencies;
        public FBoxSphereBounds3f MeshBounds;
        public List<uint16> ImposterAtlas;
        public uint32 NumRootPages;
        public int32 PositionPrecision;
        public int32 NormalPrecision;
        public uint32 NumInputTriangles;
        public uint32 NumInputVertices;
        public uint32 NumClusters;

        [Location("void FResources::Serialize(FArchive& Ar, UObject* Owner, bool bCooked)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            if (!StripFlags.IsAudioVisualDataStripped())
            {
                SerializeInternal(transfer);
            }
            return this;
        }

        private static void SerializeInternal(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public struct FPageStreamingState : ITransferable
    {
        public uint32 BulkOffset;
        public uint32 BulkSize;
        public uint32 PageSize;
        public uint32 DependenciesStart;
        public uint16 DependenciesNum;
        public uint8 MaxHierarchyDepth;
        public uint8 Flags;

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public struct FPackedHierarchyNode : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
