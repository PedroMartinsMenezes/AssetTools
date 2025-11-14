namespace AssetTool
{
    public class TBulkData<T> : ITransferable
    {
        public FBulkMetaData Meta = new();

        [Location("void FBulkData::Serialize(FArchive& Ar, UObject* Owner, bool bAttemptFileMapping, int32 ElementSize, EFileRegionType FileRegionType)")]
        public ITransferable Move(Transfer transfer)
        {
            SerializeBulkData(transfer);
            return this;
        }

        [Location("bool FLinkerLoad::SerializeBulkData(FBulkData& BulkData, const FBulkDataSerializationParams& Params)")]
        private void SerializeBulkData(Transfer transfer)
        {
            SerializeBulkMeta(transfer);
        }

        [Location("void FLinkerLoad::SerializeBulkMeta(UE::BulkData::Private::FBulkMetaData& Meta, int64& DuplicateSerialOffset, int32 ElementSize)")]
        private void SerializeBulkMeta(Transfer transfer)
        {
            Meta.FromSerialized(transfer);
        }
    }

    public class FByteBulkData : TBulkData<byte>
    {
    }

    public class FWordBulkData : TBulkData<UInt16>
    {
    }

    public class FIntBulkData : TBulkData<Int32>
    {
    }

    public class FFloatBulkData : TBulkData<float>
    {
    }

    public class FBulkMetaData
    {
        public FBulkMetaResource Resource;

        [Location("bool FBulkMetaData::FromSerialized(FArchive& Ar, int64 ElementSize, FBulkMetaData& OutMetaData, int64& OutDuplicateOffset)")]
        public FBulkMetaData FromSerialized(Transfer transfer)
        {
            transfer.Move(ref Resource);
            return this;
        }
    }

    public class FBulkMetaResource : ITransferable
    {
        public EBulkDataFlags Flags;
        public Int64 ElementCount;
        public Int64 SizeOnDisk;
        public Int64 Offset;
        public EBulkDataFlags DuplicateFlags;
        public Int64 DuplicateSizeOnDisk;
        public Int64 DuplicateOffset;
        public UInt16 DummyValue;

        [Location("FArchive& operator<<(FArchive& Ar, FBulkMetaResource& BulkMeta)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Flags);
            if (Flags.HasFlag(EBulkDataFlags.BULKDATA_Size64Bit))
            {
                transfer.Move(ref ElementCount);
                transfer.Move(ref SizeOnDisk);
                transfer.Move(ref Offset);
                if (Flags.HasFlag(EBulkDataFlags.BULKDATA_BadDataVersion))
                {
                    transfer.Move(ref DummyValue);
                }
                if (Flags.HasFlag(EBulkDataFlags.BULKDATA_DuplicateNonOptionalPayload))
                {
                    transfer.MoveEnum(ref DuplicateFlags);
                    transfer.Move(ref DuplicateSizeOnDisk);
                    transfer.Move(ref DuplicateOffset);
                }
            }
            else
            {
                transfer.MoveAsInt(ref ElementCount);
                transfer.MoveAsInt(ref SizeOnDisk);
                transfer.Move(ref Offset);
                if (Flags.HasFlag(EBulkDataFlags.BULKDATA_BadDataVersion))
                {
                    transfer.Move(ref DummyValue);
                }
                if (Flags.HasFlag(EBulkDataFlags.BULKDATA_DuplicateNonOptionalPayload))
                {
                    transfer.MoveEnum(ref DuplicateFlags);
                    transfer.MoveAsInt(ref DuplicateSizeOnDisk);
                    transfer.Move(ref DuplicateOffset);
                }
            }
            return this;
        }
    }

    public class FFormatContainer : ITransferable
    {
        public Int32 NumFormats;
        public List<FName> Names;
        public List<FByteBulkData> Bulks;

        [Location("void FFormatContainer::Serialize(FArchive& Ar, UObject* Owner, const TArray<FName>* FormatsToSave, bool bSingleUse, uint16 InAlignment, bool bInline, bool bMapped)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref NumFormats);
            transfer.Resize(ref Names, NumFormats);
            transfer.Resize(ref Bulks, NumFormats);
            for (int i = 0; i < NumFormats; i++)
            {
                Names[i].Move(transfer);
                Bulks[i].Move(transfer);
            }
            return this;
        }
    }

    [Flags]
    public enum EBulkDataFlags : UInt32
    {
        BULKDATA_None = 0,
        BULKDATA_PayloadAtEndOfFile = 1 << 0,
        BULKDATA_SerializeCompressedZLIB = 1 << 1,
        BULKDATA_ForceSingleElementSerialization = 1 << 2,
        BULKDATA_SingleUse = 1 << 3,
        BULKDATA_Unused = 1 << 5,
        BULKDATA_ForceInlinePayload = 1 << 6,
        BULKDATA_SerializeCompressed = (BULKDATA_SerializeCompressedZLIB),
        BULKDATA_ForceStreamPayload = 1 << 7,
        BULKDATA_PayloadInSeperateFile = 1 << 8,
        BULKDATA_SerializeCompressedBitWindow = 1 << 9,
        BULKDATA_Force_NOT_InlinePayload = 1 << 10,
        BULKDATA_OptionalPayload = 1 << 11,
        BULKDATA_MemoryMappedPayload = 1 << 12,
        BULKDATA_Size64Bit = 1 << 13,
        BULKDATA_DuplicateNonOptionalPayload = 1 << 14,
        BULKDATA_BadDataVersion = 1 << 15,
        BULKDATA_NoOffsetFixUp = 1 << 16,
        BULKDATA_WorkspaceDomainPayload = 1 << 17,
        BULKDATA_LazyLoadable = 1 << 18,
        BULKDATA_UsesIoDispatcher = 1u << 31,
        BULKDATA_DataIsMemoryMapped = 1 << 30,
        BULKDATA_HasAsyncReadPending = 1 << 29,
        BULKDATA_AlwaysAllowDiscard = 1 << 28,
    }
}