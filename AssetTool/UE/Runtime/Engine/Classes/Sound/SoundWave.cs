namespace AssetTool
{
    [JsonAsset("SoundWave")]
    public class USoundWave : USoundBase
    {
        public FBool bCooked;
        public FName DummyCompressionName;
        public FGuid CompressedDataGuid;
        public bool bShouldStreamSound = true;
        public bool bSupportsStreaming = true;
        public FByteBulkData TempOldBulkData;
        public FStreamedAudioPlatformData RunningPlatformData;

        [Location("void USoundWave::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bCooked);
            if (Supports.VER_UE4_SOUND_COMPRESSION_TYPE_ADDED && !Supports.RemoveSoundWaveCompressionName)
            {
                transfer.Move(ref DummyCompressionName);
            }
            if (bCooked)
            {
                throw new InvalidOperationException();
            }
            if (!Supports.SoundWaveVirtualizationUpdate)
            {
                transfer.Move(ref TempOldBulkData);
            }
            transfer.Move(ref CompressedDataGuid);
            if (bShouldStreamSound)
            {
                if (bCooked)
                {
                    if (bSupportsStreaming)
                    {
                        SerializeCookedPlatformData(transfer);
                    }
                }
            }
            return this;
        }

        [Location("void USoundWave::SerializeCookedPlatformData(FArchive& Ar)")]
        private void SerializeCookedPlatformData(Transfer transfer)
        {
            transfer.Move(ref RunningPlatformData);
        }
    }

    public class FStreamedAudioPlatformData : ITransferible
    {
        public Int32 NumChunks;
        public FName AudioFormat;
        public List<FStreamedAudioChunk> Chunks;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NumChunks);
            transfer.Move(ref AudioFormat);
            transfer.Move(ref Chunks);
            return this;
        }
    }

    public class FStreamedAudioChunk : ITransferible
    {
        public FStreamedAudioChunkEnum Flags;
        public FByteBulkData BulkData;
        public Int32 DataSize;
        public Int32 AudioDataSize;
        public UInt32 SeekOffsetInAudioFrames;
        public FString DerivedDataKey;

        [Location("void FStreamedAudioChunk::Serialize(FArchive& Ar, UObject* Owner, int32 ChunkIndex)")]
        public ITransferible Move(Transfer transfer)
        {
            Flags = (FStreamedAudioChunkEnum)transfer.Move((int)Flags);
            transfer.Move(ref BulkData);
            transfer.Move(ref DataSize);
            transfer.Move(ref AudioDataSize);
            if (Flags.HasFlag(FStreamedAudioChunkEnum.HasSeekOffset))
            {
                transfer.Move(ref SeekOffsetInAudioFrames);
            }
            if (!Flags.HasFlag(FStreamedAudioChunkEnum.IsCooked))
            {
                transfer.Move(ref DerivedDataKey);
            }
            return this;
        }
    }

    public enum FStreamedAudioChunkEnum
    {
        IsCooked = 1 << 0,
        HasSeekOffset = 1 << 1
    };
}
