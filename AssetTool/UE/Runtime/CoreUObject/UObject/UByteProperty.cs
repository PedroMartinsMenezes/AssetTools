namespace AssetTool
{
    [JsonAsset("ByteProperty")]
    public class UByteProperty : UNumericProperty
    {
        public UInt32 Enum;

        [Location("void UByteProperty::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Enum);
            return this;
        }
    }
}
