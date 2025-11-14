namespace AssetTool
{
    using UID_Type = UInt16;

    public class FSmartNameContainer : ITransferable
    {
        public Dictionary<FName, FSmartNameMapping> NameMappings;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref NameMappings);
            return this;
        }
    }

    public class FSmartNameMapping : ITransferable
    {
        public Dictionary<FName, FGuid> TempGuidMap;
        public UID_Type NextUidTemp;
        public Dictionary<TUInt16, FName> TempUidMap;
        public Dictionary<FName, FCurveMetaData> CurveMetaDataMap;

        [Location("void FSmartNameMapping::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.SmartNameRefactor)
            {
                if (!transfer.Supports.SmartNameRefactorForDeterministicCooking)
                {
                    transfer.Move(ref TempGuidMap);
                }
            }
            else if (transfer.Supports.VER_UE4_SKELETON_ADD_SMARTNAMES)
            {
                transfer.Move(ref NextUidTemp);
                transfer.Move(ref TempUidMap);
            }
            if (transfer.Supports.MoveCurveTypesToSkeleton)
            {
                transfer.Move(ref CurveMetaDataMap);
            }
            return this;
        }
    }

    [TransferableStruct("SmartName")]
    public class FSmartName : ITransferable
    {
        public FName DisplayName;
        public UID_Type TempUID;
        public FGuid TempGUID;

        [Location("bool FSmartName::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref DisplayName);
            if (!transfer.Supports.RemoveUIDFromSmartNameSerialize)
            {
                transfer.Move(ref TempUID);
            }
            if (!transfer.Supports.SmartNameRefactorForDeterministicCooking)
            {
                transfer.Move(ref TempGUID);
            }
            return this;
        }
    }

}
