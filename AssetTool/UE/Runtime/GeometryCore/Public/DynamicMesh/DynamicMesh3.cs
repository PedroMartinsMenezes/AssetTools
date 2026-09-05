

namespace AssetTool.Geometry
{
    public class FDynamicMesh3 : ITransferable
    {
        public FDynamicMesh3SerializationOptions Options;

        #region SerializeInternal_InitialVersion
        public int32 SerializationVersion;
        public TDynamicVector<FVector3d> Vertices;
        public FRefCountVector VertexRefCounts;
        public TDynamicVector<FVector3f> VertexNormals;
        public TDynamicVector<FVector3f> VertexColors;
        public TDynamicVector<FVector2f> VertexUVs;
        public FSmallListSet VertexEdgeLists;
        public TDynamicVector<FIndex3i> Triangles;
        public FRefCountVector TriangleRefCounts;
        public TDynamicVector<FIndex3i> TriangleEdges;
        public TDynamicVector<TInt32> TriangleGroups;
        public int GroupIDCounter;
        public TDynamicVector<FEdge> Edges;
        public FRefCountVector EdgeRefCounts;
        public bool bHasAttributes;
        public FDynamicMeshAttributeSet AttributeSet;
        #endregion

        #region SerializeInternal_CompactAndCompress_Default
        public bool bTriangleVectorHasHoles;
        public bool hasVertexNormals;
        public bool hasVertexColors;
        public bool hasVertexUVs;
        public bool hasTriangleGroups;
        #endregion

        #region SerializeInternal_CompactAndCompress_CompactData
        public FCompactMaps CompactMaps;
        #endregion

        [Location("void FDynamicMesh3::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                SerializeInternal_InitialVersion(transfer);
            }
            else
            {
                transfer.Move(ref Options);
                switch (Options.ImplementationVariant())
                {
                    case EImplementationVariant.Default:
                        SerializeInternal_CompactAndCompress_Default(transfer);
                        break;
                    case EImplementationVariant.CompactData:
                        SerializeInternal_CompactAndCompress_CompactData(transfer);
                        break;
                }
            }
            return this;
        }

        #region SerializeInternal_InitialVersion
        [Location("void FDynamicMesh3::SerializeInternal<InitialVersion>(FArchive& Ar, void*)")]
        private void SerializeInternal_InitialVersion(Transfer transfer)
        {
            transfer.Move(ref SerializationVersion);
            transfer.Move(ref Vertices);
            transfer.Move(ref VertexRefCounts);
            transfer.Move(ref VertexNormals);
            transfer.Move(ref VertexColors);
            transfer.Move(ref VertexUVs);
            transfer.Move(ref VertexEdgeLists);
            transfer.Move(ref Triangles);
            transfer.Move(ref TriangleRefCounts);
            transfer.Move(ref TriangleEdges);
            transfer.Move(ref TriangleGroups);
            transfer.Move(ref GroupIDCounter);
            transfer.Move(ref Edges);
            transfer.Move(ref EdgeRefCounts);
            transfer.Move(ref bHasAttributes);
            if (bHasAttributes)
            {
                transfer.Move(ref AttributeSet);
            }
        }
        #endregion

        #region SerializeInternal_CompactAndCompress_Default
        [Location("void FDynamicMesh3::SerializeInternal<CompactAndCompress + FDynamicMesh3SerializationOptions::Default>(FArchive& Ar, void* OptionsPtr)")]
        private void SerializeInternal_CompactAndCompress_Default(Transfer transfer)
        {
            SerializeUniqueVertexData(transfer);

            SerializeUniqueTriangleData(transfer);

            transfer.Move(ref bTriangleVectorHasHoles);

            if (bTriangleVectorHasHoles)
            {
                SerializeRefCounts(transfer, ref TriangleRefCounts, ref Options);
            }

            if (Options.bPreserveDataLayout)
            {
                SerializeVector(transfer, ref Edges, ref Options);
                SerializeRefCounts(transfer, ref EdgeRefCounts, ref Options);
                SerializeVector(transfer, ref TriangleEdges, ref Options);
                SerializeSmallListSet(transfer, ref VertexEdgeLists, ref Options);
            }
        }

        private void SerializeUniqueVertexData(Transfer transfer)
        {
            SerializeVector(transfer, ref Vertices, ref Options);
            SerializeOptionalVector(transfer, ref VertexNormals, ref Options, ref hasVertexNormals);
            SerializeOptionalVector(transfer, ref VertexColors, ref Options, ref hasVertexColors);
            SerializeOptionalVector(transfer, ref VertexUVs, ref Options, ref hasVertexUVs);
        }

        private static void SerializeVector<T>(Transfer transfer, ref TDynamicVector<T> vector, ref FDynamicMesh3SerializationOptions options) where T : ITransferable, new()
        {
            transfer.Move(ref vector, true, options.bUseCompression);
        }

        private static void SerializeOptionalVector<T>(Transfer transfer, ref TDynamicVector<T> optionalVector, ref FDynamicMesh3SerializationOptions options, ref bool bHasOptionalVector) where T : ITransferable, new()
        {
            transfer.Move(ref bHasOptionalVector);
            if (bHasOptionalVector)
            {
                SerializeVector(transfer, ref optionalVector, ref options);
            }
        }

        private void SerializeUniqueTriangleData(Transfer transfer)
        {
            SerializeVector(transfer, ref Triangles, ref Options);
            SerializeOptionalVector(transfer, ref TriangleGroups, ref Options, ref hasTriangleGroups);
            transfer.Move(ref GroupIDCounter);
        }

        private static void SerializeRefCounts(Transfer transfer, ref FRefCountVector refCounts, ref FDynamicMesh3SerializationOptions options)
        {
            transfer.Move(ref refCounts, options.bCompactData, options.bUseCompression);
        }

        private static void SerializeSmallListSet(Transfer transfer, ref FSmallListSet vertexEdgeLists, ref FDynamicMesh3SerializationOptions options)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SerializeInternal_CompactAndCompress_CompactData
        [Location("void FDynamicMesh3::SerializeInternal<CompactAndCompress + FDynamicMesh3SerializationOptions::CompactData>(FArchive& Ar, void* OptionsPtr)")]
        private void SerializeInternal_CompactAndCompress_CompactData(Transfer transfer)
        {
            SerializeUniqueVertexData(transfer);
            SerializeUniqueTriangleData(transfer);
            SerializeAttributeSet(transfer);
        }

        [Location("void SerializeAttributeSet(FArchive& Ar, FDynamicMesh3* Mesh, const FCompactMaps* CompactMaps, const FDynamicMesh3SerializationOptions& Options)")]
        private void SerializeAttributeSet(Transfer transfer)
        {
            transfer.Move(ref bHasAttributes);
            if (bHasAttributes)
            {
                transfer.Move(ref AttributeSet, CompactMaps, Options.bUseCompression);
            }
        }
        #endregion
    }

    public class FDynamicMesh3SerializationOptions : ITransferable
    {
        public bool bPreserveDataLayout;
        public bool bCompactData;
        public bool bUseCompression;

        [Location("friend FArchive& operator<<(FArchive& Ar, FDynamicMesh3SerializationOptions& Options)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bPreserveDataLayout);
            transfer.Move(ref bCompactData);
            transfer.Move(ref bUseCompression);
            return this;
        }

        public EImplementationVariant ImplementationVariant()
        {
            return bCompactData ? EImplementationVariant.CompactData : EImplementationVariant.Default;
        }
    }

    public class FEdge : ITransferable
    {
        public FIndex2i Vert;
        public FIndex2i Tri;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Vert);
            transfer.Move(ref Tri);
            return this;
        }
    }

    public enum EImplementationVariant : UInt32
    {
        Default = 0,
        CompactData = 1 << 16
    }

    enum EDynamicMeshSerializationVersion
    {
        InitialVersion = 1,
        CompactAndCompress = 2
    }
}
