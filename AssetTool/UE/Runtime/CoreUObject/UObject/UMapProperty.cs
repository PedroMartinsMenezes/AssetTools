namespace AssetTool
{
    [JsonAsset("MapProperty")]
    public class UMapProperty : UProperty
    {
        public UInt32 KeyProp;
        public UInt32 ValueProp;

        [Location("void UMapProperty::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref KeyProp);
            transfer.Move(ref ValueProp);
            return this;
        }
    }
}
