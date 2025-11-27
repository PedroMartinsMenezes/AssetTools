namespace AssetTool
{
    [JsonAsset("ClassProperty")]
    public class UClassProperty : UProperty
    {
        public UInt32 MetaClass;

        [Location("void UClassProperty::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MetaClass);
            return this;
        }
    }
}
