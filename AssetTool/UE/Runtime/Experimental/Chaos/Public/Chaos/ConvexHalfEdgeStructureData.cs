namespace AssetTool.Chaos
{
    [Location("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/Experimental/Chaos/Public/Chaos/ConvexHalfEdgeStructureData.h")]
    public class TConvexHalfEdgeStructureData<FIndex> : ITransferible where FIndex : ITransferible
    {
        public List<FPlaneData> Planes;
        public List<FHalfEdgeData> HalfEdges;
        public List<FVertexData> Vertices;
        public List<FIndex> Edges;

        [Location("void Serialize(FArchive& Ar) at 556")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Planes);
            transfer.Move(ref HalfEdges);
            transfer.Move(ref Vertices);
            if (transfer.Supports.ChaosConvexHasUniqueEdgeSet)
            {
                transfer.Move(ref Edges);
            }
            return this;
        }

        public class FPlaneData : ITransferible
        {
            public FIndex FirstHalfEdgeIndex;
            public FIndex NumHalfEdges;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref FirstHalfEdgeIndex);
                transfer.Move(ref NumHalfEdges);
                return this;
            }
        }

        public class FHalfEdgeData : ITransferible
        {
            public FIndex PlaneIndex;
            public FIndex VertexIndex;
            public FIndex TwinHalfEdgeIndex;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref PlaneIndex);
                transfer.Move(ref VertexIndex);
                transfer.Move(ref TwinHalfEdgeIndex);
                return this;
            }
        }

        public class FVertexData : ITransferible
        {
            public FIndex FirstHalfEdgeIndex;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref FirstHalfEdgeIndex);
                return this;
            }
        }
    }
}
