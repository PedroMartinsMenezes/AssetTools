namespace AssetTool.Chaos
{
    public class FImplicitObjectUnion : FImplicitObject
    {
        public List<TRefCountPtr<FImplicitObject>> MObjects;
        public SerializeAsAABB3 MLocalBoundingBox;
        public FLargeImplicitObjectUnionData LegacyData;
        public FBool bHierarchyBuilt;
        public EBits Bits;
        public uint16 DummyNumLeafObjects;
        public int32 NumLeafObjects;
        public FImplicitBVH BVH;

        [Location("void FImplicitObjectUnion::Serialize(FChaosArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MObjects);
            transfer.Move(ref MLocalBoundingBox);
            if (!transfer.Supports.UnionObjectsCanAvoidHierarchy)
            {
                LegacySerializeBVH(transfer);
                transfer.Move(ref bHierarchyBuilt);
            }
            else if (!transfer.Supports.ChaosImplicitObjectUnionBVHRefactor)
            {
                transfer.Move(ref bHierarchyBuilt);
                if (bHierarchyBuilt)
                {
                    LegacySerializeBVH(transfer);
                }
            }
            else
            {
                Bits = (EBits)transfer.Move((byte)Bits);
                if (!transfer.Supports.ChaosImplicitObjectUnionLeafObjectsToInt32)
                {
                    transfer.Move(ref DummyNumLeafObjects);
                }
                else
                {
                    transfer.Move(ref NumLeafObjects);
                }
                if (Bits.HasFlag(EBits.bHasBVH))
                {
                    transfer.Move(ref BVH);
                }
            }
            return this;
        }

        [Location("void FImplicitObjectUnion::LegacySerializeBVH(FChaosArchive& Ar)")]
        private void LegacySerializeBVH(Transfer transfer)
        {
            transfer.Move(ref LegacyData);
        }

        public enum EBits : byte
        {
            bAllowBVH = 1,
            bHasBVH = 2,
        }
    }

    public class FImplicitObjectUnionClustered : FImplicitObjectUnion
    {
        public override ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }

    public class FLargeImplicitObjectUnionData : ITransferible
    {
        public FGeometryParticles3d GeomParticles;
        public TBoundingVolumeHierarchyFGeometryParticles Hierarchy;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref GeomParticles);
            transfer.Move(ref Hierarchy);
            return this;
        }
    }
}
