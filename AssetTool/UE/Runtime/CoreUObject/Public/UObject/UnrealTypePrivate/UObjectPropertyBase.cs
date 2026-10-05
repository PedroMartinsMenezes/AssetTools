namespace AssetTool
{
    public class UObjectPropertyBase : UProperty
    {
        public UInt32 PropertyClass;

        [Location("void UObjectPropertyBase::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyClass);
            return this;
        }
    }
}
