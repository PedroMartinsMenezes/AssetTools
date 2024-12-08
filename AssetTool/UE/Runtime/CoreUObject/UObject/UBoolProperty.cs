namespace AssetTool
{
    [JsonAsset("BoolProperty")]
    public class UBoolProperty : UProperty
    {
        public byte BoolSize;
        public byte NativeBool;

        [Location("void UBoolProperty::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref BoolSize);
            transfer.Move(ref NativeBool);
            return this;
        }
    }
}
