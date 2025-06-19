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
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!transfer.Supports.VER_UE4_TIGHTLY_PACKED_ENUMS)
            {
                transfer.Move(ref TempNames);
            }
            else if (!transfer.Supports.EnumProperties)
            {
                transfer.Move(ref OldNames);
            }
            else
            {
                transfer.Move(ref Names);
            }

            if (!transfer.Supports.VER_UE4_ENUM_CLASS_SUPPORT)
                transfer.Move(ref bIsNamespace);
            else
                transfer.Move(ref EnumTypeByte);

            return this;
        }
    }
}
