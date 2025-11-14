namespace AssetTool
{
    public class FPCGMetadataAttribute<T> : FPCGMetadataAttributeBase where T : ITransferable, new()
    {
        public List<T> Values;
        public T DefaultValue;

        [Location("virtual void Serialize(UPCGMetadata* InMetadata, FArchive& InArchive) override")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Values);
            transfer.Move(ref DefaultValue);
            return this;
        }
    }

    public class FPCGMetadataAttributeBool : FPCGMetadataAttributeBase
    {
        public List<TUInt8> Values;
        public FBool DefaultValue;

        [Location("virtual void Serialize(UPCGMetadata* InMetadata, FArchive& InArchive) override")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Values);
            transfer.Move(ref DefaultValue);
            return this;
        }
    }
}


