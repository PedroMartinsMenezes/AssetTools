namespace AssetTool
{
    [JsonAsset("EnumProperty")]
    public class UEnumProperty : UProperty
    {
        public UInt32 Enum;
        public UInt32 UnderlyingProp;

        [Location("void UEnumProperty::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Enum);
            transfer.Move(ref UnderlyingProp);
            return this;
        }
    }
}
