namespace AssetTool
{
    [Location("void UStructProperty::Serialize(FArchive& Ar)")]
    [JsonAsset("StructProperty")]
    public class UStructProperty : UProperty
    {
        public const string TypeName = "StructProperty";

        public UInt32 StructPtr;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StructPtr);
            return this;
        }
    }
}
