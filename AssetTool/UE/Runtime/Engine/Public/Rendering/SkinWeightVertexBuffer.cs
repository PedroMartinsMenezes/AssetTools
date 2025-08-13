namespace AssetTool
{
    public class FSkinWeightVertexBuffer : ITransferible
    {
        public FSkinWeightDataVertexBuffer DataVertexBuffer;
        public FSkinWeightLookupVertexBuffer LookupVertexBuffer;

        [Location("FArchive& operator<<(FArchive& Ar, FSkinWeightVertexBuffer& VertexBuffer)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DataVertexBuffer);//? -> 11446 OK
            if (!transfer.Supports.UnlimitedBoneInfluences)
            {
                transfer.Move(ref LookupVertexBuffer);
            }
            else
            {
                transfer.Move(ref LookupVertexBuffer);
            }
            return this;
        }
    }

    public class FSkinWeightDataVertexBuffer : FVertexBuffer, ITransferible
    {
        public FStripDataFlags StripFlags;
        public bool bExtraBoneInfluences;
        public uint32 NumVertices;
        public uint32 Stride;
        public bool bVariableBonesPerVertex;
        public uint32 MaxBoneInfluences;
        public uint32 NumBoneWeights;
        public bool bUse16BitBoneIndex;
        public bool bUse16BitBoneWeight;
        public FStaticMeshVertexDataInterface WeightData;
        public FStaticMeshVertexDataInterface LegacyWeightData;

        [Location("FArchive& operator<<(FArchive& Ar, FSkinWeightDataVertexBuffer& VertexBuffer)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            SerializeMetaData(transfer);
            AllocateData();
            if (!StripFlags.IsAudioVisualDataStripped())
            {
                if (!transfer.Supports.UnlimitedBoneInfluences)
                {
                    if (MaxBoneInfluences > Consts.MAX_INFLUENCES_PER_STREAM)
                        LegacyWeightData ??= new FSkinWeightVertexData<TLegacySkinWeightInfo<ConstTrue>>();
                    else
                        LegacyWeightData ??= new FSkinWeightVertexData<TLegacySkinWeightInfo<ConstFalse>>();

                    LegacyWeightData.Move(transfer);
                }
                else
                {
                    WeightData.Move(transfer);
                }
            }
            return this;
        }

        private void AllocateData()
        {
            WeightData ??= new FSkinWeightVertexData<TUInt8>();
        }

        private void SerializeMetaData(Transfer transfer)
        {
            if (!transfer.Supports.UnlimitedBoneInfluences)
            {
                if (!transfer.Supports.SplitModelAndRenderData)
                {
                    transfer.Move(ref bExtraBoneInfluences);
                    transfer.Move(ref NumVertices);
                }
                else
                {
                    transfer.Move(ref bExtraBoneInfluences);
                    transfer.Move(ref Stride);
                    transfer.Move(ref NumVertices);
                }
            }
            else
            {
                transfer.Move(ref bVariableBonesPerVertex);
                transfer.Move(ref MaxBoneInfluences);
                transfer.Move(ref NumBoneWeights);
                transfer.Move(ref NumVertices);
            }
            if (transfer.Supports.IncreaseBoneIndexLimitPerChunk)
            {
                transfer.Move(ref bUse16BitBoneIndex);
            }
            if (transfer.Supports.IncreasedSkinWeightPrecision)
            {
                transfer.Move(ref bUse16BitBoneWeight);
            }
        }
    }

    public class FSkinWeightLookupVertexBuffer : FVertexBuffer, ITransferible
    {
        public FStripDataFlags StripFlags;
        public uint32 NumVertices;
        public FStaticMeshVertexDataInterface LookupData;

        [Location("FArchive& operator<<(FArchive& Ar, FSkinWeightLookupVertexBuffer& VertexBuffer)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            SerializeMetaData(transfer);
            AllocateData();
            if (!StripFlags.IsAudioVisualDataStripped())
            {
                if (transfer.Supports.UnlimitedBoneInfluences)
                {
                    LookupData.Move(transfer);
                }
            }
            return this;
        }

        private void AllocateData()
        {
            LookupData ??= new TStaticMeshVertexData<TUInt32>();
        }

        private void SerializeMetaData(Transfer transfer)
        {
            if (transfer.Supports.UnlimitedBoneInfluences)
            {
                transfer.Move(ref NumVertices);
            }
        }
    }

    public class FSkinWeightVertexData<T> : TStaticMeshVertexData<T> where T : ITransferible, new()
    {
    }

    public class TLegacySkinWeightInfo<T> : ITransferible where T : ConstBool
    {
        public uint16[] InfluenceBones;
        public TUInt8[] InfluenceWeights;

        public TLegacySkinWeightInfo()
        {
            bool bExtraBoneInfluences = typeof(T) == typeof(ConstTrue);
            int NumInfluences = bExtraBoneInfluences ? Consts.EXTRA_BONE_INFLUENCES : Consts.MAX_INFLUENCES_PER_STREAM;
            InfluenceBones = new uint16[NumInfluences];
            InfluenceWeights = new TUInt8[NumInfluences];
        }

        [Location("friend FArchive& operator<<(FArchive& Ar, TLegacySkinWeightInfo& I)")]
        public ITransferible Move(Transfer transfer)
        {
            for (uint32 InfluenceIndex = 0; InfluenceIndex < InfluenceBones.Length; InfluenceIndex++)
            {
                if (!transfer.Supports.IncreaseBoneIndexLimitPerChunk)
                {
                    transfer.MoveAsByte(ref InfluenceBones[InfluenceIndex]);
                }
                else
                {
                    transfer.Move(ref InfluenceBones[InfluenceIndex]);
                }
            }
            for (uint32 InfluenceIndex = 0; InfluenceIndex < InfluenceWeights.Length; InfluenceIndex++)
            {
                transfer.Move(ref InfluenceWeights[InfluenceIndex]);
            }
            return this;
        }
    }
}
