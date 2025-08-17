using System.ComponentModel;
using System.Diagnostics;

namespace AssetTool.Geometry
{
    [DebuggerDisplay("{Blocks}")]
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

        [DebuggerDisplay("Elements({Elements.Count}) Bulks({BulkElements.Count}) Chunks({CompressionChunks.Length}) Data({CompressionData.Length})")]
        public class TBlockVector<ArrayType> : ITransferible<uint, bool, bool> where ArrayType : ITransferible, new()
        {
            public List<ArrayType> Elements;
            public TBulkList<ArrayType> BulkElements;
            public FBool bUseCompressionForBulkSerialization;
            public FCompressedChunkInfo PackageFileTag;
            public FCompressedChunkInfo Summary;
            public FCompressedChunkInfo[] CompressionChunks;
            public uint8 CompressorNum;
            public FString CompressionFormatToDecode;
            public byte[] CompressionData;

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
                        transfer.Move(ref BulkElements);
                    }
                }
                return this;
            }

            [Location("void FArchive::SerializeCompressedNew(void* V, int64 Length, FName CompressionFormatToEncode, FName CompressionFormatToDecodeOldV1Files,  ECompressionFlags Flags, bool bTreatBufferAsFileReader, int64 * OutPartialReadLength)")]
            private void SerializeCompressedNew(Transfer transfer)
            {
                bool bWasByteSwapped = false;
                uint64 ARCHIVE_V2_HEADER_TAG = (ObjectVersion.PACKAGE_FILE_TAG | ((uint64)0x22222222 << 32));

                transfer.Move(ref PackageFileTag);

                if (PackageFileTag.CompressedSize != ObjectVersion.PACKAGE_FILE_TAG)
                {
                    if (PackageFileTag.CompressedSize == ObjectVersion.PACKAGE_FILE_TAG_SWAPPED || PackageFileTag.CompressedSize == ByteSwap.BYTESWAP_ORDER64((uint64)ObjectVersion.PACKAGE_FILE_TAG))
                    {
                        bWasByteSwapped = true;
                    }
                    else if (PackageFileTag.CompressedSize == ARCHIVE_V2_HEADER_TAG || PackageFileTag.CompressedSize == ByteSwap.BYTESWAP_ORDER64(ARCHIVE_V2_HEADER_TAG))
                    {
                        bWasByteSwapped = (PackageFileTag.CompressedSize != ARCHIVE_V2_HEADER_TAG);
                        FCompressionUtil.SerializeCompressorName(transfer, ref CompressorNum, ref CompressionFormatToDecode);
                    }
                }

                transfer.Move(ref Summary);

                if (bWasByteSwapped)
                {
                    Summary.CompressedSize = ByteSwap.BYTESWAP_ORDER64(Summary.CompressedSize);
                    Summary.UncompressedSize = ByteSwap.BYTESWAP_ORDER64(Summary.UncompressedSize);
                    PackageFileTag.UncompressedSize = ByteSwap.BYTESWAP_ORDER64(PackageFileTag.UncompressedSize);
                }

                uint64 LoadingCompressionChunkSize = PackageFileTag.UncompressedSize;
                if (LoadingCompressionChunkSize == ObjectVersion.PACKAGE_FILE_TAG)
                    LoadingCompressionChunkSize = Compression.LOADING_COMPRESSION_CHUNK_SIZE;
                uint64 TotalChunkCount = FMath.DivideAndRoundUp(Summary.UncompressedSize, LoadingCompressionChunkSize);

                transfer.Move(ref CompressionChunks, (int)TotalChunkCount);

                uint64 totalSize = (uint64)CompressionChunks.Select(x => (int)x.CompressedSize).Sum();

                transfer.Move(ref CompressionData, (int)totalSize);
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
