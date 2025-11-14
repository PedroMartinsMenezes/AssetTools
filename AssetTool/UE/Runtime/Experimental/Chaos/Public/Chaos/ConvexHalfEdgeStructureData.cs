using System.Diagnostics;

namespace AssetTool.Chaos
{
    [Location("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/Experimental/Chaos/Public/Chaos/ConvexHalfEdgeStructureData.h")]
    [DebuggerDisplay("Planes({Planes.Count}) HalfEdges({HalfEdges.Count}) Vertices({Vertices.Count}) Edges({Edges.Count})")]
    public class TConvexHalfEdgeStructureData<FIndex> : ITransferable where FIndex : ITransferable, new()
    {
        public List<FPlaneData> Planes;
        public List<FHalfEdgeData> HalfEdges;
        public List<FVertexData> Vertices;
        public List<FIndex> Edges;

        [Location("void Serialize(FArchive& Ar) at 556")]
        public ITransferable Move(Transfer transfer)
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

        [DebuggerDisplay("{FirstHalfEdgeIndex} {NumHalfEdges}")]
        public class FPlaneData : ITransferable
        {
            public FIndex FirstHalfEdgeIndex;
            public FIndex NumHalfEdges;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref FirstHalfEdgeIndex);
                transfer.Move(ref NumHalfEdges);
                return this;
            }
        }

        [DebuggerDisplay("{PlaneIndex} {VertexIndex} {TwinHalfEdgeIndex}")]
        public class FHalfEdgeData : ITransferable
        {
            public FIndex PlaneIndex;
            public FIndex VertexIndex;
            public FIndex TwinHalfEdgeIndex;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref PlaneIndex);
                transfer.Move(ref VertexIndex);
                transfer.Move(ref TwinHalfEdgeIndex);
                return this;
            }
        }

        [DebuggerDisplay("{FirstHalfEdgeIndex}")]
        public class FVertexData : ITransferable
        {
            public FIndex FirstHalfEdgeIndex;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref FirstHalfEdgeIndex);
                return this;
            }
        }
    }
}
