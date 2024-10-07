namespace AssetTool
{
    public class UObjectPropertyBase : UProperty
    {
        public UInt32 PropertyClass;

        [Location("void UObjectPropertyBase::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyClass);
            return this;
        }
    }
}
