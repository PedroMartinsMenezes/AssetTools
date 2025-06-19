namespace AssetTool.Chaos
{
    public class TSimpleGeometryParticles3d : TParticles3
    {
        [Location("virtual void Serialize(FChaosArchive& Ar) at 70")]
        public override ITransferible Move(Transfer transfer)
        {
            //TParticles < T, d >::Serialize(Ar);
            //Ar.UsingCustomVersion(FFortniteValkyrieBranchObjectVersion::GUID);
            //if (Ar.CustomVer(FFortniteValkyrieBranchObjectVersion::GUID) < FFortniteValkyrieBranchObjectVersion::RefCountedOImplicitObjects)
            //{
            //    TArrayCollectionArray<TSerializablePtr<FImplicitObject>> LGeometry;
            //    TArrayCollectionArray<TUniquePtr<Chaos::FImplicitObject>> LDynamicGeometry;
            //    Ar << LGeometry << LDynamicGeometry;
            //
            //    if (Ar.IsLoading())
            //    {
            //        MGeometry.SetNumUninitialized(LGeometry.Num());
            //        uint32 ImplicitIndex = 0;
            //        for (const TSerializablePtr<FImplicitObject>&ImplicitObjectPtr : LGeometry)
            //{
            //            MGeometry[ImplicitIndex++] = ImplicitObjectPtr->CopyGeometry();
            //        }
            //    }
            //}
            //else
            //{
            //    Ar << MGeometry;
            //}
            //
            //Ar.UsingCustomVersion(FUE5ReleaseStreamObjectVersion::GUID);
            //if (Ar.CustomVer(FUE5ReleaseStreamObjectVersion::GUID) >= FUE5ReleaseStreamObjectVersion::SinglePrecisonParticleDataPT)
            //{
            //    Ar << MR;
            //}
            //else
            //{
            //    TArrayCollectionArray<TRotation<FReal, d>> RDouble;
            //    RDouble.Resize(MR.Num());
            //    for (int32 Index = 0; Index < MR.Num(); ++Index)
            //    {
            //        RDouble[Index] = TRotation<FReal, d>(MR[Index]);
            //    }
            //
            //    Ar << RDouble;
            //
            //    MR.Resize(RDouble.Num());
            //    for (int32 Index = 0; Index < RDouble.Num(); ++Index)
            //    {
            //        MR[Index] = TRotation<FRealSingle, d>(RDouble[Index]);
            //    }
            //}
            throw new NotImplementedException();
        }
    }
}
