namespace AssetTool
{
    [Location("void UObjectPropertyBase::Serialize(FArchive& Ar)")]
    public class UObjectPropertyBase : UProperty
    {
        public UInt32 PropertyClass;

        public new UObjectPropertyBase Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyClass);
            return this;
        }
    }
}
