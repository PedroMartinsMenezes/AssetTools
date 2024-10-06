namespace AssetTool
{
    using UID_Type = UInt16;

    public class FSmartNameContainer : ITransferible
    {
        public Dictionary<FName, FSmartNameMapping> NameMappings;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NameMappings);
            return this;
        }
    }

    public class FSmartNameMapping : ITransferible
    {
        public Dictionary<FName, FGuid> TempGuidMap;
        public UID_Type NextUidTemp;
        public Dictionary<TUInt16, FName> TempUidMap;
        public Dictionary<FName, FCurveMetaData> CurveMetaDataMap;

        [Location("void FSmartNameMapping::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (Supports.SmartNameRefactor)
            {
                if (!Supports.SmartNameRefactorForDeterministicCooking)
                {
                    transfer.Move(ref TempGuidMap);
                }
            }
            else if (Supports.VER_UE4_SKELETON_ADD_SMARTNAMES)
            {
                transfer.Move(ref NextUidTemp);
                transfer.Move(ref TempGuidMap);
            }
            if (Supports.MoveCurveTypesToSkeleton)
            {
                transfer.Move(ref CurveMetaDataMap);
            }
            return this;
        }
    }

    [TransferibleStruct("SmartName")]
    public class FSmartName : ITransferible
    {
        public FName DisplayName;
        public UID_Type TempUID;
        public FGuid TempGUID;

        [Location("bool FSmartName::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DisplayName);
            if (!Supports.RemoveUIDFromSmartNameSerialize)
            {
                transfer.Move(ref TempUID);
            }
            if (!Supports.SmartNameRefactorForDeterministicCooking)
            {
                transfer.Move(ref TempGUID);
            }
            return this;
        }
    }

}
