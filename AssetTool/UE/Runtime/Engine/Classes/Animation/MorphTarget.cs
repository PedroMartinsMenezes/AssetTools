namespace AssetTool
{
    [JsonAsset("MorphTarget")]
    public class UMorphTarget : UObject
    {
        public FStripDataFlags StripFlags;
        public List<FMorphTargetLODModel> MorphLODModels;

        [Location("void UMorphTarget::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags);
            if (!StripFlags.IsDataStrippedForServer())
            {
                transfer.Move(ref MorphLODModels);
            }
            return this;
        }
    }

    public class FMorphTargetLODModel : ITransferible
    {
        public List<FMorphTargetDelta> Vertices;
        public Int32 NumBaseMeshVerts;
        public List<Int32> SectionIndices;
        public FBool bVerticesAreStrippedForCookedBuilds;
        public Int32 NumVertices;
        public FBool bGeneratedByEngine;

        [Location("FArchive& operator<<(FArchive& Ar, FMorphTargetLODModel& M)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.AddedMorphTargetSectionIndices)
            {
                transfer.Move(ref Vertices);
                transfer.Move(ref NumBaseMeshVerts);
            }
            else if (!Supports.SaveGeneratedMorphTargetByEngine)
            {
                transfer.Move(ref Vertices);
                transfer.Move(ref NumBaseMeshVerts);
                transfer.Move(ref SectionIndices);
            }
            else
            {
                if (Supports.StripMorphTargetSourceDataForCookedBuilds)
                {
                    transfer.Move(ref bVerticesAreStrippedForCookedBuilds);
                }
                if (bVerticesAreStrippedForCookedBuilds)
                {
                    transfer.Move(ref NumVertices);
                }
                else
                {
                    transfer.Move(ref Vertices);
                }
                transfer.Move(ref NumBaseMeshVerts);
                transfer.Move(ref SectionIndices);
                transfer.Move(ref bGeneratedByEngine);
            }
            return this;
        }
    }

    public class FMorphTargetDelta : ITransferible
    {
        public FVector3f PositionDelta;
        public FVector3f TangentZDelta;
        public FDeprecatedSerializedPackedNormal TangentZDelta_DEPRECATED;
        public UInt32 SourceIdx;

        [Location("friend FArchive& operator<<(FArchive& Ar, FMorphTargetDelta& V)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.VER_UE4_MORPHTARGET_CPU_TANGENTZDELTA_FORMATCHANGE)
            {
                transfer.Move(ref PositionDelta);
                transfer.Move(ref TangentZDelta_DEPRECATED);
                transfer.Move(ref SourceIdx);
            }
            else
            {
                transfer.Move(ref PositionDelta);
                transfer.Move(ref TangentZDelta);
                transfer.Move(ref SourceIdx);
            }
            return this;
        }
    }
}