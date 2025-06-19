namespace AssetTool
{
    public class FPCGMetadataAttribute<T> : FPCGMetadataAttributeBase where T : ITransferible
    {
        public List<T> Values;
        public T DefaultValue;

        [Location("virtual void Serialize(UPCGMetadata* InMetadata, FArchive& InArchive) override")]
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);
            transfer.Move(ref Values);
            transfer.Move(ref DefaultValue);
            return this;
        }
    }
}


