namespace AssetTool
{
    [JsonAsset("Enum")]
    public class UEnum : UField
    {
        public List<FName> TempNames;
        public List<KeyValuePair<FName, TUInt8>> OldNames;
        public List<KeyValuePair<FName, TInt64>> Names;

        [Location("void UEnum::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_TIGHTLY_PACKED_ENUMS))
            {
                TempNames = TempNames.Resize(transfer);
                TempNames.ForEach(x => transfer.Move(x));
            }
            else if (!Supports.CustomVer(FCoreObjectVersion.Enums.EnumProperties))
            {
                OldNames = OldNames.Resize(transfer);
                OldNames.ForEach(x =>
                {
                    transfer.Move(x.Key);
                    x.Value.Move(transfer);
                });
            }
            else
            {
                Names = Names.Resize(transfer);
                Names.ForEach(x =>
                {
                    transfer.Move(x.Key);
                    x.Value.Move(transfer);
                });
            }

            return this;
        }
    }
}
