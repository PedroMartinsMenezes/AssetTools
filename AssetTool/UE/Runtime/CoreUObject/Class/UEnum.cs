namespace AssetTool
{
    [JsonAsset("Enum")]
    public class UEnum : UField
    {
        public List<FName> TempNames;
        public Dictionary<FName, TUInt8> OldNames;
        public Dictionary<FName, TInt64> Names;
        public FBool bIsNamespace;
        public byte EnumTypeByte;

        [Location("void UEnum::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);//3125

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_TIGHTLY_PACKED_ENUMS))
            {
                TempNames = TempNames.Resize(transfer);
                TempNames.ForEach(x => transfer.Move(x));
            }
            else if (!Supports.CustomVer(FCoreObjectVersion.Enums.EnumProperties))
            {
                OldNames = OldNames.Resize(transfer);
                foreach (var pair in OldNames)
                {
                    transfer.Move(pair.Key);
                    pair.Value.Move(transfer);
                }
            }
            else
            {
                Names = Names.Resize(transfer);
                foreach (var pair in Names)
                {
                    transfer.Move(pair.Key);
                    pair.Value.Move(transfer);
                }
            }

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ENUM_CLASS_SUPPORT))
            {
                transfer.Move(ref bIsNamespace);
            }
            else
            {
                transfer.Move(ref EnumTypeByte);
            }

            return this;
        }
    }
}
