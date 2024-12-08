namespace AssetTool
{
    [JsonAsset("SetProperty")]
    public class USetProperty : UProperty
    {
        public UInt32 ElementProp;

        [Location("void USetProperty::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref ElementProp);
            return this;
        }
    }
}
