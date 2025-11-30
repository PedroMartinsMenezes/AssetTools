namespace AssetTool.Geometry
{
    #region FDynamicMeshUVOverlay
    public class FDynamicMeshUVOverlayFloat1 : ITransferable<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<TFloat> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferable Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref ElementsRefCounts, false, false);
                transfer.Move(ref Elements, false, false);
                transfer.Move(ref ParentVertices, false, false);
                transfer.Move(ref ElementTriangles, false, false);
            }
            else
            {
                transfer.Move(ref ElementsRefCounts, false, bUseCompression);
                transfer.Move(ref Elements, true, bUseCompression);
                transfer.Move(ref ParentVertices, true, bUseCompression);
            }
            transfer.Move(ref ElementTriangles, true, bUseCompression);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TDynamicMeshVectorOverlayFloat2 : ITransferable<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<FVector2f> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferable Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref ElementsRefCounts, false, false);
                transfer.Move(ref Elements, false, false);
                transfer.Move(ref ParentVertices, false, false);
                transfer.Move(ref ElementTriangles, false, false);
            }
            else
            {
                transfer.Move(ref ElementsRefCounts, false, bUseCompression);
                transfer.Move(ref Elements, true, bUseCompression);
                transfer.Move(ref ParentVertices, true, bUseCompression);
            }
            transfer.Move(ref ElementTriangles, true, bUseCompression);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TDynamicMeshVectorOverlayFloat3 : ITransferable<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<FVector3f> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferable Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref ElementsRefCounts, false, false);
                transfer.Move(ref Elements, false, false);
                transfer.Move(ref ParentVertices, false, false);
                transfer.Move(ref ElementTriangles, false, false);
            }
            else
            {
                transfer.Move(ref ElementsRefCounts, false, bUseCompression);
                transfer.Move(ref Elements, true, bUseCompression);
                transfer.Move(ref ParentVertices, true, bUseCompression);
            }
            transfer.Move(ref ElementTriangles, true, bUseCompression);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FDynamicMeshUVOverlayFloat4 : ITransferable<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<FVector4f> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferable Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref ElementsRefCounts, false, false);
                transfer.Move(ref Elements, false, false);
                transfer.Move(ref ParentVertices, false, false);
                transfer.Move(ref ElementTriangles, false, false);
            }
            else
            {
                transfer.Move(ref ElementsRefCounts, false, bUseCompression);
                transfer.Move(ref Elements, true, bUseCompression);
                transfer.Move(ref ParentVertices, true, bUseCompression);
            }
            transfer.Move(ref ElementTriangles, true, bUseCompression);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
