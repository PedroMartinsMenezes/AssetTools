namespace AssetTool.Chaos
{
    using FVec3Type = TVec3;
    using FPlaneType = TPlaneConcrete;

    public class FConvex : FImplicitObject
    {
        public List<TPlane3> TmpPlanes;
        public List<FPlaneType> Planes;
        public SerializeAsAABB3 LocalBoundingBox;
        public float VolumeFloat;
        public FVec3Type CenterOfMass;
        public List<FVec3Type> Vertices;
        public TParticles3 TmpSurfaceParticles;
        public float MarginFloat;
        public FConvexStructureData StructureData;
        public FVec3 UnitMassInertiaTensor;
        public TRotation3d RotationOfMass;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 890")]
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);
            if (!transfer.Supports.ConvexUsesTPlaneConcrete)
            {
                transfer.Move(ref TmpPlanes);
            }
            else
            {
                transfer.Move(ref Planes);
            }

            bool bConvexVerticesNewFormatUE4 = transfer.Supports.ConvexUsesVerticesArray;
            bool bConvexVerticesNewFormatUE5 = transfer.Supports.ConvexUsesVerticesArray;
            bool bConvexVerticesNewFormatFN = transfer.Supports.ChaosConvexVariableStructureDataAndVerticesArray;
            bool bConvexVerticesNewFormat = bConvexVerticesNewFormatUE4 || bConvexVerticesNewFormatUE5 || bConvexVerticesNewFormatFN;

            if (!bConvexVerticesNewFormat)
            {
                transfer.Move(ref TmpSurfaceParticles);
                int32 NumVertices = TmpSurfaceParticles.Size();
                for (int32 VertexIndex = 0; VertexIndex < NumVertices; ++VertexIndex)
                {
                    Vertices[VertexIndex] = TmpSurfaceParticles.GetX(VertexIndex);
                }
            }
            else
            {
                transfer.Move(ref Vertices);
            }

            transfer.Move(ref LocalBoundingBox);

            if (transfer.Supports.AddConvexCenterOfMassAndVolume)
            {
                transfer.Move(ref VolumeFloat);
                transfer.Move(ref CenterOfMass);
            }

            if (transfer.Supports.MarginAddedToConvexAndBox)
            {
                transfer.Move(ref MarginFloat);
            }

            if (transfer.Supports.StructureDataAddedToConvex)
            {
                transfer.Move(ref StructureData);
            }

            if (transfer.Supports.AddedInertiaTensorAndRotationOfMassAddedToConvex)
            {
                transfer.Move(ref UnitMassInertiaTensor);
                transfer.Move(ref RotationOfMass);
            }

            return this;
        }
    }
}
