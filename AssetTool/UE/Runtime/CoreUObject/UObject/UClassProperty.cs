namespace AssetTool
{
    [JsonAsset("ClassProperty")]
    public class UClassProperty : UObjectProperty
    {
        public UInt32 MetaClass;

        [Location("void UClassProperty::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MetaClass);
            return this;
        }
    }
}
