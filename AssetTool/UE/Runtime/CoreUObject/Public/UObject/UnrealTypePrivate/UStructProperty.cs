namespace AssetTool
{
    [JsonAsset("StructProperty")]
    public class UStructProperty : UProperty
    {
        public FObjectPtr StructPtr;

        [Location("void UStructProperty::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StructPtr);
            return this;
        }
    }
}
