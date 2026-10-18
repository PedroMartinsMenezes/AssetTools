namespace AssetTool
{
    public class FEditorBulkData : ITransferable
    {
        public EFlags Flags;
        public FGuid BulkDataId;
        public FIoHash PayloadContentId;
        public Int64 PayloadSize;
        public Int64 OffsetInFile;

        [Location("void FEditorBulkData::Serialize(FArchive& Ar, UObject* Owner, bool bAllowRegister)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Flags);
            transfer.Move(ref BulkDataId);
            transfer.Move(ref PayloadContentId);
            transfer.Move(ref PayloadSize);
            if (!IsStoredInPackageTrailer())
            {
                transfer.Move(ref OffsetInFile);
            }
            return this;
        }

        private bool IsStoredInPackageTrailer()
        {
            return Flags.HasFlag(EFlags.StoredInPackageTrailer);
        }
    }

    [Flags]
    public enum EFlags : UInt32
    {
        None = 0,
        IsVirtualized = 1 << 0,
        HasPayloadSidecarFile = 1 << 1,
        ReferencesLegacyFile = 1 << 2,
        LegacyFileIsCompressed = 1 << 3,
        DisablePayloadCompression = 1 << 4,
        LegacyKeyWasGuidDerived = 1 << 5,
        HasRegistered = 1 << 6,
        IsTornOff = 1 << 7,
        ReferencesWorkspaceDomain = 1 << 8,
        StoredInPackageTrailer = 1 << 9,
        IsCooked = 1 << 10,
        WasDetached = 1 << 11
    }
}
