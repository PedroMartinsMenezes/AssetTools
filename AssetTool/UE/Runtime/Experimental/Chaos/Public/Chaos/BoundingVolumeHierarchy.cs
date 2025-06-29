namespace AssetTool.Chaos
{
    public class TBoundingVolumeHierarchyFGeometryParticles : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TBoundingVolumeHierarchy<OBJECT_ARRAY, LEAF_TYPE> : ITransferible where OBJECT_ARRAY : ITransferible, new() where LEAF_TYPE : ITransferible, new()
    {
        public int32[] MGlobalObjects;
        public SerializeAsAABBs MWorldSpaceBoxes;
        public int32 MMaxLevels;
        public List<TBVHNode3> Elements;
        public List<LEAF_TYPE> Leafs;

        [Location("void TBoundingVolumeHierarchy<OBJECT_ARRAY, LEAF_TYPE, T, d>::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MGlobalObjects);
            transfer.Move(ref MWorldSpaceBoxes);
            transfer.Move(ref MMaxLevels);
            transfer.Move(ref Elements);
            transfer.Move(ref Leafs);
            return this;
        }
    }

    public class TBVHNode3 : ITransferible
    {
        public int32 LeafIndex;
        public int32 MAxis;
        public int32[] MChildren;
        public TVector3 MMax;
        public TVector3 MMin;

        public ITransferible Move(Transfer transfer)
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
