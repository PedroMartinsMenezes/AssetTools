namespace AssetTool.Geometry
{
    public class TDynamicMeshOverlay<RealType, ElementSize> : ITransferible where RealType : ITransferible where ElementSize : struct
    {
        public virtual ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TDynamicMeshVectorOverlay<RealType, ElementSize, VectorType> : TDynamicMeshOverlay<RealType, ElementSize>, ITransferible where RealType : ITransferible where ElementSize : struct where VectorType : ITransferible
    {
        public override ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    #region FDynamicMeshUVOverlay
    public class FDynamicMeshUVOverlayFloat1 : ITransferible<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<TFloat> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferible Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
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

        public ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TDynamicMeshVectorOverlayFloat2 : ITransferible<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<FVector2f> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferible Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
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

        public ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TDynamicMeshVectorOverlayFloat3 : ITransferible<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<FVector3f> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferible Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
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

        public ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FDynamicMeshUVOverlayFloat4 : ITransferible<FCompactMaps, bool>
    {
        public FRefCountVector ElementsRefCounts;
        public TDynamicVector<FVector4f> Elements;
        public TDynamicVector<TInt32> ParentVertices;
        public TDynamicVector<TInt32> ElementTriangles;

        [Location("void TDynamicMeshOverlay<RealType, ElementSize>::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferible Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
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

        public ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
