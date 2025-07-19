using System.ComponentModel;

namespace AssetTool.Geometry
{
    public class TDynamicVector<Type> : ITransferible<bool, bool> where Type : ITransferible, new()
    {
        public uint CurBlock;
        public uint CurBlockUsed;
        public TBlockVector<TStaticArray<Type>> Blocks;
        public uint SerializeNum;

        public ITransferible Move(Transfer transfer)
        {
            return Move(transfer, false, false);
        }

        [Description("template <bool bForceBulkSerialization = false, bool bUseCompression = false>")]
        [Location("void Serialize(FArchive& Ar) at 164")]
        public ITransferible Move(Transfer transfer, bool bForceBulkSerialization, bool bUseCompression)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref CurBlock);
                transfer.Move(ref CurBlockUsed);
                Blocks ??= new();
                Blocks.Serialize_LegacyLoad(transfer);
            }
            else
            {
                transfer.Move(ref SerializeNum);
                if (SerializeNum > 0)
                {
                    transfer.Move(ref Blocks, SerializeNum, bForceBulkSerialization, bUseCompression);
                }
            }
            return this;
        }

        public class TBlockVector<ArrayType> : ITransferible<uint, bool, bool> where ArrayType : ITransferible, new()
        {
            public List<ArrayType> Elements;
            public TBulkList<ArrayType> BulkElements;
            public FBool bUseCompressionForBulkSerialization;
            public FCompressedChunkInfo PackageFileTag;
            public FCompressedChunkInfo Summary;

            public ITransferible Move(Transfer transfer)
            {
                throw new NotImplementedException();
            }

            [Location("void Serialize(FArchive& Ar, uint32 Num) at 454")]
            public ITransferible Move(Transfer transfer, uint Num, bool bForceBulkSerialization, bool bUseCompression)
            {
                bool bUseBulkSerialization = true;

                transfer.Move(ref bUseCompressionForBulkSerialization);

                const uint BlockSize = 512;
                bool bNumIsNotMultipleOfBlockSize = Num % BlockSize != 0;
                uint32 NumBlocks = Num / BlockSize;
                if (bNumIsNotMultipleOfBlockSize)
                    NumBlocks++;

                if (bUseCompressionForBulkSerialization)
                {
                    SerializeCompressedNew(transfer);
                }
                else
                {
                    for (uint32 Index = 0; Index < NumBlocks; ++Index)
                    {
                        if (bUseBulkSerialization)
                        {
                            transfer.Move(ref BulkElements);
                        }
                        else
                        {
                            transfer.Move(ref Elements);
                        }
                    }
                }
                return this;
            }

            [Location("void FArchive::SerializeCompressedNew(void* V, int64 Length, FName CompressionFormatToEncode, FName CompressionFormatToDecodeOldV1Files,  ECompressionFlags Flags, bool bTreatBufferAsFileReader, int64 * OutPartialReadLength)")]
            private void SerializeCompressedNew(Transfer transfer)
            {
                transfer.Move(ref PackageFileTag);
                transfer.Move(ref Summary);
                ///int64 LoadingCompressionChunkSize = PackageFileTag.UncompressedSize;
                ///if (LoadingCompressionChunkSize == ObjectVersion.PACKAGE_FILE_TAG)
                ///{
                ///    LoadingCompressionChunkSize = Compression.LOADING_COMPRESSION_CHUNK_SIZE;
                ///}
                ///int64 TotalChunkCount = FMath.DivideAndRoundUp(Summary.UncompressedSize, LoadingCompressionChunkSize);
                ///for (int64 ChunkIndex = 0; ChunkIndex < TotalChunkCount; ChunkIndex++)
                ///{
                ///    *this << CompressionChunks[ChunkIndex];
                ///}
                ///for (int64 ChunkIndex = 0; ChunkIndex < TotalChunkCount; ChunkIndex++)
                ///{
                ///    Serialize( CompressedBuffer, Chunk.CompressedSize );
                ///}
            }

            [Location("void Serialize_LegacyLoad(FArchive& Ar) at 410")]
            public ITransferible Serialize_LegacyLoad(Transfer transfer)
            {
                bool bIsLWCBulkSerializedDoubleType = typeof(Type) == typeof(FVector2d) || typeof(Type) == typeof(FVector3d) || typeof(Type) == typeof(FVector4d) || typeof(Type) == typeof(FQuat4d) || typeof(Type) == typeof(FTransform3d);
                bool bUseBulkSerialization = TCanBulkSerialize.Value<Type>() && !(bIsLWCBulkSerializedDoubleType && !transfer.Supports.LARGE_WORLD_COORDINATES);
                if (bUseBulkSerialization)
                    transfer.Move(ref BulkElements);
                else
                    transfer.Move(ref Elements);
                return this;
            }
        }
    }


}
