namespace AssetTool
{
    [JsonAsset("StructProperty")]
    public class UStructProperty : UProperty
    {
        public UInt32 StructPtr;

        [Location("void UStructProperty::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StructPtr);
            return this;
        }
    }
}
