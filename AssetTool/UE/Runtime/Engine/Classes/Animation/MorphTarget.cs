namespace AssetTool
{
    [JsonAsset("MorphTarget")]
    public class UMorphTarget : UObject
    {
        public FStripDataFlags StripFlags;
        public List<FMorphTargetLODModel> MorphLODModels;

        [Location("void UMorphTarget::Serialize( FArchive& Ar )")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags);
            if (!StripFlags.IsAudioVisualDataStripped())
            {
                transfer.Move(ref MorphLODModels);
            }
            return this;
        }
    }

    public class FMorphTargetLODModel : ITransferable
    {
        public List<FMorphTargetDelta> Vertices;
        public Int32 NumBaseMeshVerts;
        public Int32[] SectionIndices;
        public FBool bVerticesAreStrippedForCookedBuilds;
        public Int32 NumVertices;
        public FBool bGeneratedByEngine;
        public FString SourceFilename;

        [Location("FArchive& operator<<(FArchive& Ar, FMorphTargetLODModel& M)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.AddedMorphTargetSectionIndices)
            {
                transfer.Move(ref Vertices);
                transfer.Move(ref NumBaseMeshVerts);
            }
            else if (!transfer.Supports.SaveGeneratedMorphTargetByEngine)
            {
                transfer.Move(ref Vertices);
                transfer.Move(ref NumBaseMeshVerts);
                transfer.Move(ref SectionIndices);
            }
            else
            {
                if (transfer.Supports.StripMorphTargetSourceDataForCookedBuilds)
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
                if (transfer.Supports.MorphTargetCustomImport)
                {
                    transfer.Move(ref SourceFilename);
                }
            }
            return this;
        }
    }

    public class FMorphTargetDelta : ITransferable
    {
        public FVector3f PositionDelta;
        public FVector3f TangentZDelta;
        public FDeprecatedSerializedPackedNormal TangentZDelta_DEPRECATED;
        public UInt32 SourceIdx;

        [Location("friend FArchive& operator<<(FArchive& Ar, FMorphTargetDelta& V)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_MORPHTARGET_CPU_TANGENTZDELTA_FORMATCHANGE)
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