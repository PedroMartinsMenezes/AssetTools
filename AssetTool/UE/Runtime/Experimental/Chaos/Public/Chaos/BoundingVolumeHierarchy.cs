namespace AssetTool.Chaos
{
    public class TBoundingVolumeHierarchyFGeometryParticles : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TBoundingVolumeHierarchy<OBJECT_ARRAY, LEAF_TYPE> : ITransferable where OBJECT_ARRAY : ITransferable, new() where LEAF_TYPE : ITransferable, new()
    {
        public int32[] MGlobalObjects;
        public SerializeAsAABBs MWorldSpaceBoxes;
        public int32 MMaxLevels;
        public List<TBVHNode3> Elements;
        public List<LEAF_TYPE> Leafs;

        [Location("void TBoundingVolumeHierarchy<OBJECT_ARRAY, LEAF_TYPE, T, d>::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref MGlobalObjects);
            transfer.Move(ref MWorldSpaceBoxes);
            transfer.Move(ref MMaxLevels);
            transfer.Move(ref Elements);
            transfer.Move(ref Leafs);
            return this;
        }
    }

    public class TBVHNode3 : ITransferable
    {
        public int32 LeafIndex;
        public int32 MAxis;
        public int32[] MChildren;
        public TVector3 MMax;
        public TVector3 MMin;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref LeafIndex);
            transfer.Move(ref MAxis);
            transfer.Move(ref MChildren);
            transfer.Move(ref MMax);
            transfer.Move(ref MMin);
            return this;
        }
    }
}
